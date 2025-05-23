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
