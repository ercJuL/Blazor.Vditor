namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

/// <summary>
///     Defines the preview modes available in the Vditor editor.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<PreviewModeEnum>))]
public enum PreviewModeEnum
{
    /// <summary>
    ///     Represents the mode where both the editor and preview are displayed.
    /// </summary>
    [JsonStringEnumMemberName("both")]
    Both = 0,

    /// <summary>
    ///     Represents the mode where only the editor is displayed.
    /// </summary>
    [JsonStringEnumMemberName("editor")]
    Editor = 1,
}
