// <copyright file="Vditor.Callback.Link.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for link-related operations.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     Gets or sets the callback function to be invoked when a link is clicked.
    /// </summary>
    private Func<Task>? LinkClickCallback { get; set; }

    /// <summary>
    ///     Invokes the link click callback function.
    /// </summary>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeLinkClick")]
    public async Task InvokeLinkClick()
    {
        if (this.LinkClickCallback is not null)
        {
            await this.LinkClickCallback.Invoke();
        }
    }
}
