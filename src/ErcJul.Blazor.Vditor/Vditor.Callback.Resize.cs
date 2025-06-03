// <copyright file="Vditor.Callback.Resize.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for resize-related operations.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     Gets or sets the callback function to be invoked after a resize operation.
    /// </summary>
    private Func<int, Task>? ResizeAfterCallback { get; set; }

    /// <summary>
    ///     Invokes the callback function after a resize operation.
    /// </summary>
    /// <param name="heightDelta">The change in height after the resize operation.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeResizeAfter")]
    public async Task InvokeResizeAfter(int heightDelta)
    {
        if (this.ResizeAfterCallback is not null)
        {
            await this.ResizeAfterCallback.Invoke(heightDelta);
        }
    }
}
