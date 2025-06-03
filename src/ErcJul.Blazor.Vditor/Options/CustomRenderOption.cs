// <copyright file="CustomRenderOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the configuration options for custom rendering in the Vditor editor.
/// </summary>
public class CustomRenderOption
{
    /// <summary>
    ///     Gets or sets the language used for custom rendering.
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; set; }

    // /// <summary>
    // /// Gets or sets the action to render custom content with the specified parameters.
    // /// </summary>
    // [JsonIgnore]
    // public Action<ElementReference, TODO> Render { get; set; }
}
