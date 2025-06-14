// <copyright file="PreviewOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Options for configuring the Vditor preview functionality.
/// </summary>
/// <remarks>
///     See <see href="https://ld246.com/article/1549638745630#options-preview">vditor.options-preview</see>.
/// </remarks>
public class PreviewOption
{
    /// <summary>
    ///     Gets or sets the list of custom preview actions.
    /// </summary>
    public List<PreviewActionCustom> Actions { get; set; } = [];

    /// <summary>
    ///     Gets or sets the delay time of preview debounce.
    /// </summary>
    /// <remarks>
    ///     Default is 1 second.
    /// </remarks>
    [JsonPropertyName("delay")]
    public TimeSpan? Delay { get; set; }

    /// <summary>
    ///     Gets or sets the options for configuring code highlighting.
    /// </summary>
    public HljsOption? Hljs { get; set; }

    /// <summary>
    ///     Gets or sets the options for configuring Markdown.
    /// </summary>
    public MarkdownConfig? Markdown { get; set; }

    /// <summary>
    ///     Gets or sets the options for configuring math formula rendering.
    /// </summary>
    public MathOption? Math { get; set; }

    /// <summary>
    ///     Gets or sets the maximum width of the preview in pixels.
    /// </summary>
    /// <remarks>
    ///     Default is 768.
    /// </remarks>
    [JsonPropertyName("maxWidth")]
    public uint? MaxWidth { get; set; }

    /// <summary>
    ///     Gets or sets the preview mode.
    /// </summary>
    /// <remarks>
    ///     Default is <see cref="PreviewModeEnum.Both">Both</see>.
    /// </remarks>
    [JsonPropertyName("mode")]
    public PreviewModeEnum? Mode { get; set; }

    // public TODO? Render { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for parsing operations. Ignored during JSON serialization.
    /// </summary>
    [JsonIgnore]
    public Func<Task>? Parse { get; set; }// Action<ElementReference>

    /// <summary>
    ///     Gets or sets the options for configuring the preview theme.
    /// </summary>
    public PreviewThemeOption? Theme { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for transformation operations, accepts a string parameter. Ignored during JSON
    ///     serialization.
    /// </summary>
    [JsonIgnore]
    public Func<string, Task<string>>? Transform { get; set; }

    /// <summary>
    ///     Gets or sets the URL address for markdown parse.
    /// </summary>
    /// TODO: Determine if direct implementation is needed.
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}
