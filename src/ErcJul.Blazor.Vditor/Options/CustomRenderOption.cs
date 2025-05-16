namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

public class CustomRenderOption
{
    [JsonPropertyName("language")]
    public string Language { get; set; }

    // [JsonIgnore]public Action<ElementReference, TODO> Render { get; set; }
}
