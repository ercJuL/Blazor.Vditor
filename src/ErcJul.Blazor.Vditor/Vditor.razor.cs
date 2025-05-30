namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Options;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

public partial class Vditor : ComponentBase, IAsyncDisposable
{
    private ElementReference? refEditor;
    private IJSObjectReference? vditorDotNetModule;

    [Inject]
    private IJSRuntime JsRuntime { get; set; }

    private bool Readonly => this.VditorReadonlyOption is not null;

    [Parameter]
    public VditorOption? VditorOption { get; set; }

    [Parameter]
    public VditorReadonlyOption? VditorReadonlyOption { get; set; }

    [Parameter]
    public string Content { get; set; } = string.Empty;

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

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (this.Readonly)
            {
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
                    "ercjul.vditor",
                    this.Content,
                    DotNetObjectReference.Create(this),
                    this.VditorReadonlyOption);
            }
            else
            {
                await this.vditorDotNetModule.InvokeVoidAsync(
                    "initVditor",
                    "ercjul.vditor",
                    DotNetObjectReference.Create(this),
                    this.VditorOption);
            }
        }
    }

    private void InitVditorOption()
    {
        foreach (var item in this.VditorOption.Toolbar ?? [])
        {
            item.Register(ref this.ToolbarCallbackMap);
        }

        this.ResizeAfterCallback = this.VditorOption.Resize?.After;
        this.CounterAfterCallback = this.VditorOption.Counter?.After;
        this.CacheAfterCallback = this.VditorOption.Cache?.After;
        this.PreviewParseCallback = this.VditorOption.Preview?.Parse;
        this.PreviewTransformCallback = this.VditorOption.Preview?.Transform;
        foreach (var previewAction in this.VditorOption.Preview?.Actions ?? [])
        {
            previewAction.Register(ref this.PreviewActionCallbackMap);
        }

        this.LinkClickCallback = this.VditorOption.Link?.Click;
        this.ImagePreviewCallback = this.VditorOption.Image?.Preview;
        foreach (var extendOption in this.VditorOption.Hint?.Extend ?? [])
        {
            extendOption.Register(ref this.HintCallbackMap);
        }

        this.CommentAddCallback = this.VditorOption.Comment?.Add;
        this.CommentRemoveCallback = this.VditorOption.Comment?.Remove;
        this.CommentScrollCallback = this.VditorOption.Comment?.Scroll;
        this.CommentAdjustTopCallback = this.VditorOption.Comment?.AdjustTop;

        // TODO Upload
        // TODO customRenders
    }

    private void InitVditorReadonlyOption()
    {
    }
}
