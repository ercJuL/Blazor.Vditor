namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

public class CounterOption
{
    [JsonPropertyName("enable")]
    public bool Enable { get; set; } = false;

    [JsonPropertyName("max")]
    public uint? Max { get; set; }

    [JsonPropertyName("type")]
    public ContentTypeEnum? Type { get; set; }

    [JsonIgnore]
    public Func<uint, CounterOption, Task>? After { get; set; }
}
