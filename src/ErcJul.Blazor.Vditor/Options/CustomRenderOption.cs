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
    public string Language { get; set; }

    // /// <summary>
    // /// Gets or sets the action to render custom content with the specified parameters.
    // /// </summary>
    // [JsonIgnore]
    // public Action<ElementReference, TODO> Render { get; set; }
}
