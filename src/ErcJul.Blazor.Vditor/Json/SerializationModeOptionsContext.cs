namespace ErcJul.Blazor.Vditor.Json;

using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Options;

[JsonSourceGenerationOptions(
    GenerationMode = JsonSourceGenerationMode.Serialization,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]

// [JsonSerializable(typeof(KeyEvent))]
// [JsonSerializable(typeof(CacheOption))]
// [JsonSerializable(typeof(ClassesOption))]
// [JsonSerializable(typeof(CommentOption))]
// [JsonSerializable(typeof(CounterOption))]
// [JsonSerializable(typeof(CustomRenderOption))]
[JsonSerializable(typeof(VditorOption))]
public partial class SerializationModeOptionsContext : JsonSerializerContext
{
}
