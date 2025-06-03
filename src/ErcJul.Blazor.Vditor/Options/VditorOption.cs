// <copyright file="VditorOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Options for configuring the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options">options</see>.
/// </remarks>
public class VditorOption
{
    /// <summary>
    ///     Gets or sets the delegate for actions after initialization.
    /// </summary>
    [JsonIgnore]
    public Action? After { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for blur events.
    /// </summary>
    [JsonIgnore]
    public Action<string>? Blur { get; set; }

    /// <summary>
    ///     Gets or sets the cache options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-cache">vditor.options-cache</see>.
    /// </remarks>
    [JsonPropertyName("cache")]
    public CacheOption? Cache { get; set; }

    /// <summary>
    ///     Gets or sets the CDN URL for the editor.
    /// </summary>
    /// <remarks>
    ///     Default is <c>https://unpkg.com/vditor@${VDITOR_VERSION}</c>.
    /// </remarks>
    [JsonPropertyName("cdn")]
    public string? Cdn { get; set; }

    /// <summary>
    ///     Gets or sets the custom CSS classes for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-classes">options-classes</see>.
    /// </remarks>
    [JsonPropertyName("classes")]
    public ClassesOption? Classes { get; set; }

    /// <summary>
    ///     Gets or sets the comment options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-comment">vditor.options-comment</see>.
    /// </remarks>
    [JsonPropertyName("comment")]
    public CommentOption? Comment { get; set; }

    /// <summary>
    ///     Gets or sets the counter options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-counter">vditor.options-counter</see>.
    /// </remarks>
    [JsonPropertyName("counter")]
    public CounterOption? Counter { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for Ctrl+Enter key events.
    /// </summary>
    [JsonIgnore]
    public Action<string>? CtrlEnter { get; set; }

    /// <summary>
    ///     Gets or sets the custom render options for the editor.
    /// </summary>
    [JsonPropertyName("customRender")]
    public List<CustomRenderOption>? CustomRenders { get; set; }

    /// <summary>
    ///     Gets or sets whether debugging mode is enabled.
    /// </summary>
    /// <remarks>
    ///     Default is false.
    /// </remarks>
    [JsonPropertyName("debugger")]
    public bool? Debugger { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for escape key events.
    /// </summary>
    [JsonIgnore]
    public Action<string>? Esc { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for focus events.
    /// </summary>
    [JsonIgnore]
    public Action<string>? Focus { get; set; }

    /// <summary>
    ///     Gets or sets the fullscreen options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-fullscreen">vditor.options-fullscreen</see>.
    /// </remarks>
    [JsonPropertyName("fullscreen")]
    public FullScreenOption? FullScreen { get; set; }

    /// <summary>
    ///     Gets or sets the height of the editor in pixels.
    /// </summary>
    /// <remarks>
    ///     Default is 'auto'. CSharp code is null, js will set auto.
    /// </remarks>
    [JsonPropertyName("height")]
    public uint? Height { get; set; }

    /// <summary>
    ///     Gets or sets the hint options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-hint">vditor.options-hint</see>.
    /// </remarks>
    [JsonPropertyName("hint")]
    public HintOption? Hint { get; set; }

    /// <summary>
    ///     Gets or sets the internationalization options for the editor. The priority is lower than <see cref="Language" />.
    /// </summary>
    [JsonPropertyName("i18n")]
    public I18nOption? I18n { get; set; }

    /// <summary>
    ///     Gets or sets the icon style of the editor.
    /// </summary>
    /// <remarks>
    ///     Default is <see cref="IconEnum.Antd" />.
    /// </remarks>
    [JsonPropertyName("icon")]
    public IconEnum? Icon { get; set; }

    /// <summary>
    ///     Gets or sets the image options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-image">vditor.options-image</see>.
    /// </remarks>
    [JsonPropertyName("image")]
    public ImageOption? Image { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for input events.
    /// </summary>
    [JsonIgnore]
    public Action<string>? Input { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for keydown events.
    /// </summary>
    [JsonIgnore]
    public Action<KeyEvent>? KeyDown { get; set; }

    /// <summary>
    ///     Gets or sets the language of the editor.
    /// </summary>
    /// <remarks>
    ///     Default is <see cref="LanguageEnum.SimplifiedChinese" />.
    /// </remarks>
    [JsonPropertyName("language")]
    public LanguageEnum? Language { get; set; }

    /// <summary>
    ///     Gets or sets the link options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-link">vditor.options-link</see>.
    /// </remarks>
    [JsonPropertyName("link")]
    public LinkOption? Link { get; set; }

    /// <summary>
    ///     Gets or sets the minimum height of the editor in pixels.
    /// </summary>
    [JsonPropertyName("minHeight")]
    public uint? MinHeight { get; set; }

    /// <summary>
    ///     Gets or sets the editing mode of the editor.
    /// </summary>
    /// <remarks>
    ///     Default is <see cref="EditModeEnum.Wysiwyg" />.
    /// </remarks>
    [JsonPropertyName("mode")]
    public EditModeEnum? Mode { get; set; }

    /// <summary>
    ///     Gets or sets the outline options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-outline">vditor.options-outline</see>.
    /// </remarks>
    [JsonPropertyName("outline")]
    public OutLineOption? OutLine { get; set; }

    /// <summary>
    ///     Gets or sets the placeholder text displayed in the editor.
    /// </summary>
    /// <remarks>
    ///     Default is empty.
    /// </remarks>
    [JsonPropertyName("placeholder")]
    public string? Placeholder { get; set; }

    /// <summary>
    ///     Gets or sets the preview options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-preview">vditor.options-preview</see>.
    /// </remarks>
    [JsonPropertyName("preview")]
    public PreviewOption? Preview { get; set; }

    /// <summary>
    ///     Gets or sets the resize options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-resize">vditor.options-resize</see>.
    /// </remarks>
    [JsonPropertyName("resize")]
    public ResizeOption? Resize { get; set; }

    /// <summary>
    ///     Gets or sets whether the editor uses right-to-left text direction.
    /// </summary>
    /// <remarks>
    ///     Default is false.
    /// </remarks>
    [JsonPropertyName("rtl")]
    public bool? Rtl { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for select events.
    /// </summary>
    [JsonIgnore]
    public Action<string>? Select { get; set; }

    /// <summary>
    ///     Gets or sets the tab character used in the editor.
    /// </summary>
    [JsonPropertyName("tab")]
    public string? Tab { get; set; }

    /// <summary>
    ///     Gets or sets the theme of the editor.
    /// </summary>
    /// <remarks>
    ///     Default is <see cref="ThemeEnum.Classic" />.
    /// </remarks>
    [JsonPropertyName("theme")]
    public ThemeEnum? Theme { get; set; }

    /// <summary>
    ///     Gets or sets the toolbar configuration for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-toolbar">vditor.options-toolbar</see>.
    /// </remarks>
    [JsonPropertyName("toolbar")]
    public List<MenuItem>? Toolbar { get; set; }

    /// <summary>
    ///     Gets or sets the toolbar configuration options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-toolbarConfig">vditor.options-toolbarConfig</see>.
    /// </remarks>
    [JsonPropertyName("toolbarConfig")]
    public ToolbarConfigOption? ToolbarConfig { get; set; }

    /// <summary>
    ///     Gets or sets whether typewriter mode is enabled.
    /// </summary>
    /// <remarks>
    ///     Default is false.
    /// </remarks>
    [JsonPropertyName("typewriterMode")]
    public bool? TypewriterMode { get; set; }

    /// <summary>
    ///     Gets or sets the delay time for undo operations in milliseconds.
    /// </summary>
    [JsonPropertyName("undoDelay")]
    public uint? UndoDelay { get; set; }

    /// <summary>
    ///     Gets or sets the delegate for unselect events.
    /// </summary>
    [JsonIgnore]
    public Action<string>? UnSelect { get; set; }

    /// <summary>
    ///     Gets or sets the upload options for the editor.
    /// </summary>
    /// <remarks>
    ///     <see href="https://ld246.com/article/1549638745630#options-upload">vditor.options-upload</see>.
    /// </remarks>
    [JsonPropertyName("upload")]
    public UploadOption? Upload { get; set; }

    /// <summary>
    ///     Gets or sets the initial content of the editor.
    /// </summary>
    /// <remarks>
    ///     Default is empty.
    /// </remarks>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    ///     Gets or sets the width of the editor in pixels.
    /// </summary>
    /// <remarks>
    ///     Default is 'auto'. CSharp code is null, js will set auto.
    /// </remarks>
    [JsonPropertyName("width")]
    public uint? Width { get; set; }
}
