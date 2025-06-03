// <copyright file="Vditor.Callback.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for various editor events.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     Gets or sets the callback function to be invoked after an operation.
    /// </summary>
    [Parameter]
    public EventCallback AfterCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when the editor loses focus.
    /// </summary>
    [Parameter]
    public EventCallback<string> BlurCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when Ctrl+Enter is pressed.
    /// </summary>
    [Parameter]
    public EventCallback<string> CtrlEnterCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when the Escape key is pressed.
    /// </summary>
    [Parameter]
    public EventCallback<string> EscCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when the editor gains focus.
    /// </summary>
    [Parameter]
    public EventCallback<string> FocusCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when input is provided.
    /// </summary>
    [Parameter]
    public EventCallback<string> InputCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when a key is pressed.
    /// </summary>
    [Parameter]
    public EventCallback<KeyEvent> KeydownCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when text is selected.
    /// </summary>
    [Parameter]
    public EventCallback<string> SelectCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked when text is unselected.
    /// </summary>
    [Parameter]
    public EventCallback UnSelectCallback { get; set; }

    /// <summary>
    ///     Invokes the callback function after an operation.
    /// </summary>
    /// <returns>
    ///     A <see cref="Task" /> representing the asynchronous operation.
    /// </returns>
    [JSInvokable("InvokeAfter")]
    public async Task InvokeAfter()
    {
        await this.AfterCallback.InvokeAsync(this);
    }

    /// <summary>
    ///     Invokes the callback function when the editor loses focus.
    /// </summary>
    /// <param name="value">The value of the editor when it loses focus.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeBlur")]
    public async Task InvokeBlur(string value)
    {
        await this.BlurCallback.InvokeAsync(value);
    }

    /// <summary>
    ///     Invokes the callback function when Ctrl+Enter is pressed.
    /// </summary>
    /// <param name="value">The value of the editor when Ctrl+Enter is pressed.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeCtrlEnter")]
    public async Task InvokeCtrlEnter(string value)
    {
        await this.CtrlEnterCallback.InvokeAsync(value);
    }

    /// <summary>
    ///     Invokes the callback function when the Escape key is pressed.
    /// </summary>
    /// <param name="value">The value of the editor when the Escape key is pressed.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeEscape")]
    public async Task InvokeEscape(string value)
    {
        await this.EscCallback.InvokeAsync(value);
    }

    /// <summary>
    ///     Invokes the callback function when the editor gains focus.
    /// </summary>
    /// <param name="value">The value of the editor when it gains focus.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeFocus")]
    public async Task InvokeFocus(string value)
    {
        await this.FocusCallback.InvokeAsync(value);
    }

    /// <summary>
    ///     Invokes the callback function when input is provided.
    /// </summary>
    /// <param name="value">The input value provided to the editor.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeInput")]
    public async Task InvokeInput(string value)
    {
        this.Content = value;
        await this.ContentChanged.InvokeAsync(value);
        await this.InputCallback.InvokeAsync(value);
    }

    /// <summary>
    ///     Invokes the callback function when a key is pressed.
    /// </summary>
    /// <param name="value">The key event data.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeKeydown")]
    public async Task InvokeKeydown(KeyEvent value)
    {
        await this.KeydownCallback.InvokeAsync(value);
    }

    /// <summary>
    ///     Invokes the callback function when text is selected.
    /// </summary>
    /// <param name="value">The selected text value.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeSelect")]
    public async Task InvokeSelect(string value)
    {
        await this.SelectCallback.InvokeAsync(value);
    }

    /// <summary>
    ///     Invokes the callback function when text is unselected.
    /// </summary>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeUnSelect")]
    public async Task InvokeUnSelect()
    {
        await this.UnSelectCallback.InvokeAsync();
    }
}
