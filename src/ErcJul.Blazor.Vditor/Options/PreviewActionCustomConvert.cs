// <copyright file="PreviewActionCustomConvert.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
///     A custom JSON converter for the <see cref="PreviewActionCustom" /> class.
/// </summary>
public class PreviewActionCustomConvert : JsonConverter<PreviewActionCustom>
{
    /// <summary>
    ///     Reads and converts the JSON representation of a <see cref="PreviewActionCustom" /> object.
    /// </summary>
    /// <param name="reader">The <see cref="Utf8JsonReader" /> to read from.</param>
    /// <param name="typeToConvert">The type of the object to convert.</param>
    /// <param name="options">Options to use for deserialization.</param>
    /// <returns>A deserialized <see cref="PreviewActionCustom" /> object.</returns>
    public override PreviewActionCustom Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var previewActionCustom = new PreviewActionCustom
        {
            Key = "undefined",
            Text = "undefined",
            Click = key => Task.CompletedTask,
        };
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return previewActionCustom;
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "key":
                    previewActionCustom.Key = reader.GetString() ?? string.Empty;
                    break;
                case "text":
                    previewActionCustom.Text = reader.GetString() ?? string.Empty;
                    break;
                case "className":
                    previewActionCustom.ClassName = reader.GetString();
                    break;
                case "tooltip":
                    previewActionCustom.Tooltip = reader.GetString();
                    break;
            }
        }

        return previewActionCustom;
    }

    /// <summary>
    ///     Writes a <see cref="PreviewActionCustom" /> object as a JSON representation.
    /// </summary>
    /// <param name="writer">The <see cref="Utf8JsonWriter" /> to write to.</param>
    /// <param name="value">The <see cref="PreviewActionCustom" /> object to serialize.</param>
    /// <param name="options">Options to use for serialization.</param>
    public override void Write(Utf8JsonWriter writer, PreviewActionCustom value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("key", value.Key);
        writer.WriteString("text", value.Text);
        if (value.ClassName is not null)
        {
            writer.WriteString("className", value.ClassName);
        }

        if (value.Tooltip is not null)
        {
            writer.WriteString("tooltip", value.Tooltip);
        }

        writer.WriteString("click", value.Key);

        writer.WriteEndObject();
    }
}
