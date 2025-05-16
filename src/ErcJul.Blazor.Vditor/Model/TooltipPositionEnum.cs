namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter<TooltipPositionEnum>))]
public enum TooltipPositionEnum
{
    [JsonPropertyName("n")] North,
    [JsonPropertyName("ne")] NorthEast,
    [JsonPropertyName("e")] East,
    [JsonPropertyName("se")] SouthEast,
    [JsonPropertyName("s")] South,
    [JsonPropertyName("sw")] SouthWest,
    [JsonPropertyName("w")] West,
    [JsonPropertyName("nw")] NorthWest,
}
