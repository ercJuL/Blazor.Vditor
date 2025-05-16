namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

public class FullScreenOption
{
    [JsonPropertyName("index")]
    public uint index { get; set; } = 90;
}
