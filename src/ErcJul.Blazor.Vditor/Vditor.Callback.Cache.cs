// <copyright file="Vditor.Callback.Cache.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using Microsoft.JSInterop;

/// <summary>
///     Represents the Vditor class with caching callback functionality.
/// </summary>
public partial class Vditor
{
    /// <summary>
    ///     Gets or sets the callback function to be invoked after caching.
    /// </summary>
    private Func<string, Task>? CacheAfterCallback { get; set; }

    /// <summary>
    ///     Invokes the caching callback function with the provided markdown content.
    /// </summary>
    /// <param name="markdown">The markdown content to pass to the callback function.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    [JSInvokable("InvokeCacheAfter")]
    public async Task InvokeCacheAfter(string markdown)
    {
        if (this.CacheAfterCallback is not null)
        {
            await this.CacheAfterCallback.Invoke(markdown);
        }
    }
}
