// <copyright file="ImageOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the configuration options for images in the Vditor editor.
/// </summary>
public class ImageOption
{
    /// <summary>
    ///     Gets or sets a value indicating whether image preview is enabled.
    /// </summary>
    [JsonPropertyName("isPreview")]
    public bool? IsPreview { get; set; } = true;

    /// <summary>
    ///     Gets or sets a callback function to execute the image preview operation.
    /// </summary>
    [JsonIgnore]
    public Func<Task>? Preview { get; set; }// TODO: Update to Func<ElementReference> if required.
}
