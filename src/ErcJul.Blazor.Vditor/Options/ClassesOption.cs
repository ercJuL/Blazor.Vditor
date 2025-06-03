// <copyright file="ClassesOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the configuration options for CSS classes in the Vditor editor.
/// </summary>
/// <remarks>
///     See <see href="https://ld246.com/article/1549638745630#options-classes">vditor.options-classes</see>.
/// </remarks>
public class ClassesOption
{
    /// <summary>
    ///     Gets or sets the CSS class for the preview mode.
    /// </summary>
    [JsonPropertyName("preview")]
    public string? Preview { get; set; }
}
