// <copyright file="HintExtendOptionJsonConverter.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json;
using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     A custom JSON converter for the <see cref="HintExtendOption" /> class.
/// </summary>
public class HintExtendOptionJsonConverter : JsonConverter<HintExtendOption>
{
    /// <summary>
    ///     Reads and converts the JSON data to a <see cref="HintExtendOption" /> object.
    /// </summary>
    /// <param name="reader">The <see cref="Utf8JsonReader" /> to read JSON data from.</param>
    /// <param name="typeToConvert">The type of the object to convert.</param>
    /// <param name="options">Options to customize the JSON serialization.</param>
    /// <returns>A <see cref="HintExtendOption" /> object populated with data from the JSON.</returns>
    /// <exception cref="JsonException">Thrown if the JSON does not start with an object.</exception>
    public override HintExtendOption? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException("Expected start of object.");
        }

        var option = new HintExtendOption
        {
            Key = "undefined",
        };

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

    /// <summary>
    ///     Writes a <see cref="HintExtendOption" /> object to JSON format.
    /// </summary>
    /// <param name="writer">The <see cref="Utf8JsonWriter" /> to write JSON data to.</param>
    /// <param name="value">The <see cref="HintExtendOption" /> object to serialize.</param>
    /// <param name="options">Options to customize the JSON serialization.</param>
    /// <remarks>
    ///     The <see cref="HintExtendOption.Hint" /> property cannot be serialized directly.
    ///     You may need to handle this case differently based on your requirements.
    /// </remarks>
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
