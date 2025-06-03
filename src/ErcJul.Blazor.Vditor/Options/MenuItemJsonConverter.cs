// <copyright file="MenuItemJsonConverter.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json;
using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     A custom JSON converter for the <see cref="MenuItem" /> class.
/// </summary>
public class MenuItemJsonConverter : JsonConverter<MenuItem>
{
    /// <summary>
    ///     Reads and converts the JSON data to a <see cref="MenuItem" /> object.
    /// </summary>
    /// <param name="reader">The <see cref="Utf8JsonReader" /> to read JSON data from.</param>
    /// <param name="typeToConvert">The type of the object to convert.</param>
    /// <param name="options">Options to control the JSON serialization behavior.</param>
    /// <returns>A <see cref="MenuItem" /> object deserialized from the JSON data.</returns>
    public override MenuItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            // 如果 JSON 是字符串，直接返回默认的 MenuItem
            return new MenuItem
            {
                IsDefault = true,
                Name = reader.GetString() ?? string.Empty,
            };
        }

        // 如果 JSON 是对象，逐步解析属性
        string? name = null, icon = null, className = null, tooltip = null, hotkey = null, suffix = null, prefix = null;
        TooltipPositionEnum? tooltipPosition = null;
        List<MenuItem>? toolbar = null;
        uint? level = null;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                break;
            }

            if (reader.TokenType == JsonTokenType.PropertyName)
            {
                var propertyName = reader.GetString() ?? string.Empty;
                reader.Read();

                switch (propertyName)
                {
                    case "name":
                        name = reader.GetString();
                        break;
                    case "icon":
                        icon = reader.GetString();
                        break;
                    case "className":
                        className = reader.GetString();
                        break;
                    case "tip":
                        tooltip = reader.GetString();
                        break;
                    case "hotkey":
                        hotkey = reader.GetString();
                        break;
                    case "suffix":
                        suffix = reader.GetString();
                        break;
                    case "prefix":
                        prefix = reader.GetString();
                        break;
                    case "tipPosition":
                        tooltipPosition = JsonSerializer.Deserialize<TooltipPositionEnum>(ref reader, options);
                        break;
                    case "toolbar":
                        toolbar = JsonSerializer.Deserialize<List<MenuItem>>(ref reader, options);
                        break;
                    case "level":
                        level = reader.GetUInt32();
                        break;
                }
            }
        }

        return new MenuItem
        {
            IsDefault = false,
            Name = name ?? string.Empty,
            Icon = icon,
            ClassName = className,
            Tooltip = tooltip,
            Hotkey = hotkey,
            Suffix = suffix,
            Prefix = prefix,
            TooltipPosition = tooltipPosition,
            Toolbar = toolbar,
            Level = level,
        };
    }

    /// <summary>
    ///     Writes a <see cref="MenuItem" /> object as JSON data.
    /// </summary>
    /// <param name="writer">The <see cref="Utf8JsonWriter" /> to write JSON data to.</param>
    /// <param name="value">The <see cref="MenuItem" /> object to serialize.</param>
    /// <param name="options">Options to control the JSON serialization behavior.</param>
    public override void Write(Utf8JsonWriter writer, MenuItem value, JsonSerializerOptions options)
    {
        if (value.IsDefault)
        {
            // Writes the name of the menu item as a string if it is a default item.
            writer.WriteStringValue(value.Name);
            return;
        }

        // Writes the menu item as a JSON object.
        writer.WriteStartObject();
        writer.WriteString("name", value.Name);
        if (value.Icon is not null)
        {
            writer.WriteString("icon", value.Icon);
        }

        if (value.ClassName is not null)
        {
            writer.WriteString("className", value.ClassName);
        }

        if (value.Tooltip is not null)
        {
            writer.WriteString("tip", value.Tooltip);
        }

        if (value.Hotkey is not null)
        {
            writer.WriteString("hotkey", value.Hotkey);
        }

        if (value.Suffix is not null)
        {
            writer.WriteString("suffix", value.Suffix);
        }

        if (value.Prefix is not null)
        {
            writer.WriteString("prefix", value.Prefix);
        }

        if (value.TooltipPosition is not null)
        {
            writer.WriteString("tipPosition", JsonSerializer.Serialize(value.TooltipPosition, options));
        }

        if (value.Toolbar is not null)
        {
            writer.WritePropertyName("toolbar");
            JsonSerializer.Serialize(writer, value.Toolbar, options);
        }

        if (value.Level is not null)
        {
            writer.WriteNumber("level", value.Level.Value);
        }

        if (value.OnClick is not null)
        {
            writer.WriteString("click", value.Name);
        }

        writer.WriteEndObject();
    }
}
