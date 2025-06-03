// <copyright file="Vditor.Callback.Preview.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for preview-related operations.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     A dictionary mapping keys to their corresponding preview action callback functions.
    /// </summary>
    private Dictionary<string, Func<string, Task>> previewActionCallbackMap = new();

    /// <summary>
    ///     Gets or sets the callback function to be invoked for parsing the preview.
    /// </summary>
    private Func<Task>? PreviewParseCallback { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be invoked for transforming the preview HTML.
    /// </summary>
    private Func<string, Task<string>>? PreviewTransformCallback { get; set; }

    /// <summary>
    ///     Invokes the preview action callback function associated with the specified key.
    /// </summary>
    /// <param name="key">The key identifying the preview action callback to invoke.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokePreviewActionCallback")]
    public async Task InvokePreviewActionCallback(string key)
    {
        if (this.previewActionCallbackMap.TryGetValue(key, out var callback))
        {
            await callback.Invoke(key);
        }
    }

    /// <summary>
    ///     Invokes the callback function for parsing the preview.
    /// </summary>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokePreviewParse")]
    public async Task InvokePreviewParse()
    {
        if (this.PreviewParseCallback is not null)
        {
            await this.PreviewParseCallback.Invoke();
        }
    }

    /// <summary>
    ///     Invokes the callback function for transforming the preview HTML.
    /// </summary>
    /// <param name="html">The HTML content to transform.</param>
    /// <returns>A task representing the asynchronous operation, returning the transformed HTML.</returns>
    [JSInvokable("InvokePreviewTransform")]
    public async Task<string> InvokePreviewTransform(string html)
    {
        if (this.PreviewTransformCallback is not null)
        {
            return await this.PreviewTransformCallback.Invoke(html);
        }

        return html;
    }
}
