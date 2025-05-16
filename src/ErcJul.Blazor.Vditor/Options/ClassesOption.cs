namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

public class ClassesOption
{
    [JsonPropertyName("preview")]
    public string? Priview { get; set; }
}
