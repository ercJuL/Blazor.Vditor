// <copyright file="ResizeOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the resize options for the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options-resize">vditor.options-resize</see>.
/// </remarks>
public class ResizeOption
{
    /// <summary>
    ///     Gets or sets a callback function to be executed after resizing.
    /// </summary>
    /// <remarks>
    ///     The function takes an integer parameter representing the new size and returns a <see cref="Task" />.
    /// </remarks>
    [JsonIgnore]
    public Func<int, Task>? After { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether resizing is enabled.
    /// </summary>
    /// <remarks>
    ///     If set to <c>true</c>, resizing is enabled. Defaults to <c>false</c>.
    /// </remarks>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>
    ///     Gets or sets the position of the resize handle.
    /// </summary>
    /// <remarks>
    ///     The default position is <see cref="ResizePositionEnum.Bottom" />.
    /// </remarks>
    [JsonPropertyName("position")]
    public ResizePositionEnum? Position { get; set; }
}
