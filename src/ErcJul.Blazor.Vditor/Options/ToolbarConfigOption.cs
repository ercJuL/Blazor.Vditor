namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

/// <summary>
///     Represents the configuration options for the toolbar in the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options-toolbarConfig">vditor.options-toolbarConfig</see>.
/// </remarks>
public class ToolbarConfigOption
{
    /// <summary>
    ///     Gets or sets a value indicating whether the toolbar should be hidden.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>. If set to <c>true</c>, the toolbar will not be displayed. This is useful for a
    ///     minimalistic editor interface.
    /// </remarks>
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the toolbar should be pinned.
    /// </summary>
    /// <remarks>
    ///     Default is <c>false</c>. If set to <c>true</c>, the toolbar will remain visible even when the editor is scrolled.
    /// </remarks>
    [JsonPropertyName("pin")]
    public bool? Pin { get; set; }
}
