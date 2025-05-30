namespace ErcJul.Blazor.Vditor.Model;

using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
///     Represents the extended hint options for the Vditor editor.
/// </summary>
[JsonConverter(typeof(HintExtendOptionJsonConverter))]
public class HintExtendOption
{
    /// <summary>
    ///     Gets or sets the key associated with the extended hint option.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    ///     Gets or sets a function that provides a list of hint data asynchronously based on a given key.
    /// </summary>
    /// <remarks>
    ///     The function takes a string as input and returns a task that resolves to a list of <see cref="HintData" /> objects.
    /// </remarks>
    [JsonIgnore]
    public Func<string, Task<List<HintData>>>? Hint { get; set; }

    public void Register(ref Dictionary<string, Func<string, Task<List<HintData>>>> callbackMap)
    {
        Debug.Assert(callbackMap != null, nameof(callbackMap) + " != null");

        if (this.Hint is not null)
        {
            callbackMap.Add(this.Key, this.Hint);
        }
    }
}

public class HintExtendOptionJsonConverter : JsonConverter<HintExtendOption>
{
    public override HintExtendOption? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException("Expected start of object.");
        }

        var option = new HintExtendOption();

        while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
        {
            if (reader.TokenType == JsonTokenType.PropertyName)
            {
                var propertyName = reader.GetString();
                reader.Read();

                switch (propertyName)
                {
                    case "key":
                        option.Key = reader.GetString() ?? string.Empty;
                        break;
                    default:
                        continue;
                }
            }
        }

        return option;
    }

    public override void Write(Utf8JsonWriter writer, HintExtendOption value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("key", value.Key);

        if (value.Hint is not null)
        {
            // Note: The Hint function cannot be serialized directly.
            // You may need to handle this case differently based on your requirements.
            writer.WriteString("hint", value.Key);
        }

        writer.WriteEndObject();
    }
}
