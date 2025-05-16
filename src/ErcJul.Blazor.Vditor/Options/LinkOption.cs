namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

public class LinkOption
{
    [JsonPropertyName("isOpen")]
    public bool? IsOpen { get; set; } = true;

    [JsonIgnore]
    public Func<Task>? Click { get; set; }// TODO Func<ElementReference>
}
