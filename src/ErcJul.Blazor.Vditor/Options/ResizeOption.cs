namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

public class ResizeOption
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; } = false;

    [JsonPropertyName("position")]
    public ResizePositionEnum? Position { get; set; } = ResizePositionEnum.Bottom;

    [JsonIgnore]
    public Func<int, Task>? After { get; set; }
}
