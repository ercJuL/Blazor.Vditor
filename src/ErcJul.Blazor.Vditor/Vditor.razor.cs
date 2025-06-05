// <copyright file="Vditor.razor.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Options;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, a Blazor wrapper for the Vditor editor.
/// </summary>
public partial class Vditor : ComponentBase, IAsyncDisposable
{
    private readonly Guid guid = Guid.NewGuid();

    /// <summary>
    ///     A reference to the editor's DOM element.
    /// </summary>
    private ElementReference? refEditor;

    /// <summary>
    ///     A reference to the JavaScript module for interacting with the Vditor editor.
    /// </summary>
    private IJSObjectReference? vditorDotNetModule;

    /// <summary>
    ///     Gets or sets the content of the Vditor editor.
    /// </summary>
    /// <remarks>
    ///     When the content is updated, the <see cref="ContentChanged" /> event is triggered asynchronously.
    /// </remarks>
    [Parameter]
    public string? Content { get; set; }

    /// <summary>
    ///     Gets or sets event callback triggered when the content of the editor changes.
    /// </summary>
    /// <remarks>
    ///     This callback allows handling changes to the editor's content asynchronously.
    /// </remarks>
    [Parameter]
    public EventCallback<string> ContentChanged { get; set; }

    /// <summary>
    ///     Gets or sets injected JavaScript runtime for invoking JavaScript functions.
    /// </summary>
    [Inject]
    public required IJSRuntime JsRuntime { get; set; }

    /// <summary>
    ///     Gets or sets the options for configuring the Vditor editor.
    /// </summary>
    [Parameter]
    public VditorOption? VditorOption { get; set; }

    /// <summary>
    ///     Gets or sets the options for configuring the Vditor editor in readonly mode.
    /// </summary>
    [Parameter]
    public VditorReadonlyOption? VditorReadonlyOption { get; set; }

    /// <summary>
    ///     Gets a value indicating whether the editor is in readonly mode.
    /// </summary>
    private bool Readonly => this.VditorReadonlyOption is not null;

    /// <summary>
    ///     Disposes the JavaScript module asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async ValueTask DisposeAsync()
    {
        if (this.vditorDotNetModule is not null)
        {
            try
            {
                await this.vditorDotNetModule.DisposeAsync();
            }
            catch (JSDisconnectedException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    /// <summary>
    ///     Called after the component has been rendered.
    /// </summary>
    /// <param name="firstRender">Indicates whether this is the first render.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (this.Readonly)
            {
                this.InitVditorReadonlyOption();
            }
            else
            {
                this.InitVditorOption();
            }

            this.vditorDotNetModule = await this.JsRuntime.InvokeAsync<IJSObjectReference>(
                "import",
                "./_content/ErcJul.Blazor.Vditor/Vditor.razor.js");

            if (this.Readonly)
            {
                await this.vditorDotNetModule.InvokeVoidAsync(
                    "initReadonlyVditor",
                    this.guid.ToString(),
                    this.Content,
                    DotNetObjectReference.Create(this),
                    this.VditorReadonlyOption);
            }
            else
            {
                await this.vditorDotNetModule.InvokeVoidAsync(
                    "initVditor",
                    this.guid.ToString(),
                    DotNetObjectReference.Create(this),
                    this.VditorOption);
            }
        }
    }

    /// <summary>
    ///     Called when parameters are set for the component.
    /// </summary>
    /// <returns>A task representing the asynchronous operation.</returns>
    protected override Task OnParametersSetAsync() => base.OnParametersSetAsync();

    /// <summary>
    ///     Initializes the Vditor editor options.
    /// </summary>
    private void InitVditorOption()
    {
        foreach (var item in this.VditorOption?.Toolbar ?? [])
        {
            item.Register(ref this.toolbarCallbackMap);
        }

        this.ResizeAfterCallback = this.VditorOption?.Resize?.After;
        this.CounterAfterCallback = this.VditorOption?.Counter?.After;
        this.CacheAfterCallback = this.VditorOption?.Cache?.After;
        this.PreviewParseCallback = this.VditorOption?.Preview?.Parse;
        this.PreviewTransformCallback = this.VditorOption?.Preview?.Transform;
        foreach (var previewAction in this.VditorOption?.Preview?.Actions ?? [])
        {
            previewAction.Register(ref this.previewActionCallbackMap);
        }

        this.LinkClickCallback = this.VditorOption?.Link?.Click;
        this.ImagePreviewCallback = this.VditorOption?.Image?.Preview;
        foreach (var extendOption in this.VditorOption?.Hint?.Extend ?? [])
        {
            extendOption.Register(ref this.hintCallbackMap);
        }

        this.CommentAddCallback = this.VditorOption?.Comment?.Add;
        this.CommentRemoveCallback = this.VditorOption?.Comment?.Remove;
        this.CommentScrollCallback = this.VditorOption?.Comment?.Scroll;
        this.CommentAdjustTopCallback = this.VditorOption?.Comment?.AdjustTop;

        // TODO Upload
        // TODO customRenders
    }

    /// <summary>
    ///     Initializes the Vditor editor options for readonly mode.
    /// </summary>
    private void InitVditorReadonlyOption()
    {
    }
}
