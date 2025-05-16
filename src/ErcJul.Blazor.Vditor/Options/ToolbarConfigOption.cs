namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

public class ToolbarConfigOption
{
    [JsonPropertyName("hide")]
    public bool? Hide { get; set; } = false;

    [JsonPropertyName("pin")]
    public bool? Pin { get; set; } = false;
}
