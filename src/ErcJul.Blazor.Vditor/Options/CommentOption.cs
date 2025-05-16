namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

public class CommentOption
{
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; } = false;

    // [JsonIgnore]public Action<string, string, List<CommentData>>? Add { get; set; }

    [JsonIgnore]
    public Action<List<string>>? Remove { get; set; }

    [JsonIgnore]
    public Action<uint>? Scroll { get; set; }

    // [JsonIgnore]public Action<List<CommentData>>? AdjustTop { get; set; }
}
