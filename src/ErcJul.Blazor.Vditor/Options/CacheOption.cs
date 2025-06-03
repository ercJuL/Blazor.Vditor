// <copyright file="CacheOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the cache options configuration for the Vditor editor.
/// </summary>
/// <remarks>
///     See <see href="https://ld246.com/article/1549638745630#options-cache">vditor.options-cache</see>.
/// </remarks>
public class CacheOption
{
    /// <summary>
    ///     Gets or sets a callback function to be executed after a cache operation is completed.
    /// </summary>
    /// <remarks>
    ///     The callback function takes a string parameter representing the cached content.
    /// </remarks>
    [JsonIgnore]
    public Func<string, Task>? After { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether caching is enabled.
    /// </summary>
    /// <remarks>
    ///     If set to <c>true</c>, caching is enabled. Defaults to <c>true</c>.
    /// </remarks>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    ///     Gets or sets the unique identifier for the cache.
    /// </summary>
    /// <remarks>
    ///     This identifier is used to distinguish different cache instances.
    /// </remarks>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
