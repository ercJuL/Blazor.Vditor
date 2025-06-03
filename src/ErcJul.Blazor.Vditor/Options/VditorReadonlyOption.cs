// <copyright file="VditorReadonlyOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the readonly options for the Vditor editor.
/// </summary>
public class VditorReadonlyOption
{
    /// <summary>
    ///     Gets or sets the callback function to be executed after initialization.
    /// </summary>
    public Action? After { get; set; }

    /// <summary>
    ///     Gets or sets the anchor rendering behavior.
    /// </summary>
    public AnchorEnum? Anchor { get; set; }

    /// <summary>
    ///     Gets or sets the CDN URL for loading resources.
    /// </summary>
    public string? Cdn { get; set; }

    /// <summary>
    ///     Gets or sets the custom emoji definitions.
    /// </summary>
    public Dictionary<string, string>? CustomEmoji { get; set; }

    /// <summary>
    ///     Gets or sets the path to the emoji resources.
    /// </summary>
    public string? EmojiPath { get; set; }

    /// <summary>
    ///     Gets or sets the configuration for syntax highlighting.
    /// </summary>
    public HljsOption? Hljs { get; set; }

    /// <summary>
    ///     Gets or sets the internationalization options.
    /// </summary>
    public I18nOption? I18n { get; set; }

    /// <summary>
    ///     Gets or sets the icon style for the editor.
    /// </summary>
    public IconEnum? Icon { get; set; }

    /// <summary>
    ///     Gets or sets the language configuration for the editor.
    /// </summary>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    ///     Gets or sets the URL for lazy loading images.
    /// </summary>
    public string? LazyLoadImage { get; set; }

    /// <summary>
    ///     Gets or sets the markdown configuration.
    /// </summary>
    public MarkdownConfig? Markdown { get; set; }

    /// <summary>
    ///     Gets or sets the mathematical rendering options.
    /// </summary>
    public MathOption? Math { get; set; }

    /// <summary>
    ///     Gets or sets the readonly mode for the editor.
    /// </summary>
    public ReadonlyModeEnum Mode { get; set; }

    /// <summary>
    ///     Gets or sets the speech options for the editor.
    /// </summary>
    public SpeechOption? Speech { get; set; }

    // TODO renderers

    /// <summary>
    ///     Gets or sets the preview theme options.
    /// </summary>
    public PreviewThemeOption? Theme { get; set; }

    // TODO render

    /// <summary>
    ///     Gets or sets the callback function to transform content.
    /// </summary>
    public Action<string>? Transform { get; set; }
}
