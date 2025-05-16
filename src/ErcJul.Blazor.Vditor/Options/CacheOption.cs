namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

public class CacheOption
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("enable")]
    public bool? Enable { get; set; } = true;

    [JsonIgnore]
    public Func<string, Task>? After { get; set; }
}
