// <copyright file="Vditor.Callback.Toolbar.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for toolbar-related operations.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     A dictionary mapping toolbar item IDs to their corresponding callback functions.
    /// </summary>
    private Dictionary<string, Func<Task>> toolbarCallbackMap = new();

    /// <summary>
    ///     Invokes the toolbar callback function associated with the specified ID.
    /// </summary>
    /// <param name="id">The ID of the toolbar callback to invoke.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeToolbarCallback")]
    public async Task InvokeToolbarCallback(string id)
    {
        if (this.toolbarCallbackMap.TryGetValue(id, out var callback))
        {
            await callback.Invoke();
        }
    }
}
