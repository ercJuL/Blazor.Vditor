// <copyright file="Vditor.Callback.Hint.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Model;
using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for hint-related operations.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     A dictionary mapping hint IDs to their corresponding callback functions.
    /// </summary>
    private Dictionary<string, Func<string, Task<List<HintData>>>> hintCallbackMap = new();

    /// <summary>
    ///     Invokes the hint callback function associated with the specified ID.
    /// </summary>
    /// <param name="id">The ID of the hint callback to invoke.</param>
    /// <param name="value">The value to pass to the callback function.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeHintCallback")]
    public async Task InvokeHintCallback(string id, string value)
    {
        if (this.hintCallbackMap.TryGetValue(id, out var callback))
        {
            await callback.Invoke(value);
        }
    }
}
