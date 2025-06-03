// <copyright file="LinkOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the configuration options for links in the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options-link">vditor.options-link</see>.
/// </remarks>
public class LinkOption
{
    /// <summary>
    ///     Gets or sets the callback function to be executed when the link is clicked.
    /// </summary>
    [JsonIgnore]
    public Func<Task>? Click { get; set; }// TODO: Update to Func<ElementReference> if required.

    /// <summary>
    ///     Gets or sets a value indicating whether the link should open in a new tab or window.
    /// </summary>
    /// <remarks>
    ///     If set to <c>true</c>, the link will open in a new tab or window. Defaults to <c>true</c>.
    /// </remarks>
    [JsonPropertyName("isOpen")]
    public bool? IsOpen { get; set; }
}
