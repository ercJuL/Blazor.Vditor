namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

public class ImageOption
{
    [JsonPropertyName("isPreview")]
    public bool? IsPreview { get; set; } = true;

    [JsonIgnore]
    public Func<Task>? Preview { get; set; }// TODO Func<ElementReference>
}
