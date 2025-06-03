// <copyright file="Vditor.Callback.Image.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for image-related operations.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     Gets or sets the callback function to be invoked for image preview.
    /// </summary>
    private Func<Task>? ImagePreviewCallback { get; set; }

    /// <summary>
    ///     Invokes the image preview callback function.
    /// </summary>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeImagePreview")]
    public async Task InvokeImagePreview()
    {
        if (this.ImagePreviewCallback is not null)
        {
            await this.ImagePreviewCallback.Invoke();
        }
    }
}
