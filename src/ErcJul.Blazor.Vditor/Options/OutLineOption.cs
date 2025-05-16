namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

public class OutLineOption
{
    [JsonPropertyName("enable")]
    public bool Enable { get; set; } = false;

    [JsonPropertyName("position")]
    public OutlinePositionEnum Position { get; set; } = OutlinePositionEnum.Left;
}
