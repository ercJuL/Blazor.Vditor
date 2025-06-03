// <copyright file="Vditor.Callback.Counter.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using ErcJul.Blazor.Vditor.Options;
using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor component, providing callback functionality for counter-related operations.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     Gets or sets the callback function to be invoked after the counter is updated.
    /// </summary>
    private Func<uint, CounterOption, Task>? CounterAfterCallback { get; set; }

    /// <summary>
    ///     Invokes the callback function after the counter is updated.
    /// </summary>
    /// <param name="length">The length of the content being counted.</param>
    /// <param name="counter">The counter options associated with the update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeCounterAfter")]
    public async Task InvokeCounterAfter(uint length, CounterOption counter)
    {
        if (this.CounterAfterCallback is not null)
        {
            await this.CounterAfterCallback.Invoke(length, counter);
        }
    }
}
