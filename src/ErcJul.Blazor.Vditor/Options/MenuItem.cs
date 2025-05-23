namespace ErcJul.Blazor.Vditor;

using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents a menu item in the Vditor editor.
/// </summary>
/// <remarks>
///     This class defines the properties and behavior of a menu item, including its name, icon, tooltip,
///     and other attributes. It also supports nested toolbars and click event handling.
/// </remarks>
/// <seealso href="https://ld246.com/article/1549638745630#options-toolbar">vditor.options-toolbar</seealso>
[JsonConverter(typeof(MenuItemJsonConverter))]
public class MenuItem
{
    /// <summary>
    ///     Gets or sets a value indicating whether this menu item is a default item.
    /// </summary>
    /// <seealso cref="DefaultMenuItem" />
    [JsonIgnore]
    public bool IsDefault { get; set; }

    /// <summary>
    ///     Gets or sets the name of the menu item.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or sets the icon associated with the menu item. It's Svg icon.
    /// </summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>
    ///     Gets or sets the CSS class name for the menu item.
    /// </summary>
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }

    /// <summary>
    ///     Gets or sets the tooltip text for the menu item.
    /// </summary>
    [JsonPropertyName("tooltip")]
    public string? Tooltip { get; set; }

    /// <summary>
    ///     Gets or sets the hotkey associated with the menu item. Don't support WYSIWYG edit type.
    /// </summary>
    /// <example>
    ///     ⌘/ctrl-key or ⌘/ctrl-⇧/shift-key.
    /// </example>
    [JsonPropertyName("hotKey")]
    public string? Hotkey { get; set; }

    /// <summary>
    ///     Gets or sets the suffix text for insert content.
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }

    /// <summary>
    ///     Gets or sets the prefix text for insert content.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    ///     Gets or sets the tooltip position for the menu item.
    /// </summary>
    /// <seealso cref="TooltipPositionEnum" />
    [JsonPropertyName("tipPosition")]
    public TooltipPositionEnum? TooltipPosition { get; set; }

    /// <summary>
    ///     Gets or sets the nested toolbar items for this menu item.
    /// </summary>
    [JsonPropertyName("toolbar")]
    public List<MenuItem>? Toolbar { get; set; }

    /// <summary>
    ///     Gets or sets the hierarchical level of the menu item.
    /// </summary>
    [JsonPropertyName("level")]
    public uint? Level { get; set; }

    /// <summary>
    ///     Gets or sets the action to be executed when the menu item is clicked.
    /// </summary>
    [JsonIgnore]
    public Action? OnClick { get; set; }// TODO: Add event parameters Action<EventArgs, IVditor>

    /// <summary>
    ///     Registers the menu item and its nested toolbar items into the callback map.
    /// </summary>
    /// <param name="callbackMap">The dictionary to store menu item callbacks.</param>
    public void Register(ref Dictionary<string, Action> callbackMap)
    {
        Debug.Assert(callbackMap != null, nameof(callbackMap) + " != null");
        if (!this.IsDefault)
        {
            callbackMap.Add(this.Name, this.OnClick);
        }

        if (this.Toolbar is null)
        {
            return;
        }

        foreach (var item in this.Toolbar)
        {
            item.Register(ref callbackMap);
        }
    }
}

/// <summary>
///     Provides a collection of default menu items for the Vditor editor.
/// </summary>
public static class DefaultMenuItem
{
    /// <summary>
    ///     Represents the "export" menu item.
    /// </summary>
    public static readonly MenuItem Export = new()
    {
        Name = "export",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "emoji" menu item.
    /// </summary>
    public static readonly MenuItem Emoji = new()
    {
        Name = "emoji",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "headings" menu item.
    /// </summary>
    public static readonly MenuItem Headings = new()
    {
        Name = "headings",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "bold" menu item.
    /// </summary>
    public static readonly MenuItem Bold = new()
    {
        Name = "bold",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "italic" menu item.
    /// </summary>
    public static readonly MenuItem Italic = new()
    {
        Name = "italic",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "strike" menu item.
    /// </summary>
    public static readonly MenuItem Strike = new()
    {
        Name = "strike",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "link" menu item.
    /// </summary>
    public static readonly MenuItem Link = new()
    {
        Name = "link",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "list" menu item.
    /// </summary>
    public static readonly MenuItem List = new()
    {
        Name = "list",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "ordered-list" menu item.
    /// </summary>
    public static readonly MenuItem OrderedList = new()
    {
        Name = "ordered-list",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "check" menu item.
    /// </summary>
    public static readonly MenuItem Check = new()
    {
        Name = "check",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "outdent" menu item.
    /// </summary>
    public static readonly MenuItem Outdent = new()
    {
        Name = "outdent",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "indent" menu item.
    /// </summary>
    public static readonly MenuItem Indent = new()
    {
        Name = "indent",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "quote" menu item.
    /// </summary>
    public static readonly MenuItem Quote = new()
    {
        Name = "quote",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "line" menu item.
    /// </summary>
    public static readonly MenuItem Line = new()
    {
        Name = "line",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "code" menu item.
    /// </summary>
    public static readonly MenuItem Code = new()
    {
        Name = "code",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "inline-code" menu item.
    /// </summary>
    public static readonly MenuItem InlineCode = new()
    {
        Name = "inline-code",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "insert-before" menu item.
    /// </summary>
    public static readonly MenuItem InsertBefore = new()
    {
        Name = "insert-before",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "insert-after" menu item.
    /// </summary>
    public static readonly MenuItem InsertAfter = new()
    {
        Name = "insert-after",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "upload" menu item.
    /// </summary>
    public static readonly MenuItem Upload = new()
    {
        Name = "upload",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "record" menu item.
    /// </summary>
    public static readonly MenuItem Record = new()
    {
        Name = "record",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "table" menu item.
    /// </summary>
    public static readonly MenuItem Table = new()
    {
        Name = "table",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "undo" menu item.
    /// </summary>
    public static readonly MenuItem Undo = new()
    {
        Name = "undo",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "redo" menu item.
    /// </summary>
    public static readonly MenuItem Redo = new()
    {
        Name = "redo",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "more" menu item.
    /// </summary>
    public static readonly MenuItem More = new()
    {
        Name = "more",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "fullscreen" menu item.
    /// </summary>
    public static readonly MenuItem Fullscreen = new()
    {
        Name = "fullscreen",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "edit-mode" menu item.
    /// </summary>
    public static readonly MenuItem EditMode = new()
    {
        Name = "edit-mode",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "both" menu item.
    /// </summary>
    public static readonly MenuItem Both = new()
    {
        Name = "both",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "preview" menu item.
    /// </summary>
    public static readonly MenuItem Preview = new()
    {
        Name = "preview",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "outline" menu item.
    /// </summary>
    public static readonly MenuItem Outline = new()
    {
        Name = "outline",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "content-theme" menu item.
    /// </summary>
    public static readonly MenuItem ContentTheme = new()
    {
        Name = "content-theme",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "code-theme" menu item.
    /// </summary>
    public static readonly MenuItem CodeTheme = new()
    {
        Name = "code-theme",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "devtools" menu item.
    /// </summary>
    public static readonly MenuItem Devtools = new()
    {
        Name = "devtools",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "info" menu item.
    /// </summary>
    public static readonly MenuItem Info = new()
    {
        Name = "info",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the "help" menu item.
    /// </summary>
    public static readonly MenuItem Help = new()
    {
        Name = "help",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents a delimiter menu item.
    /// </summary>
    public static readonly MenuItem Delimiter = new()
    {
        Name = "|",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents a line break menu item.
    /// </summary>
    public static readonly MenuItem Br = new()
    {
        Name = "br",
        IsDefault = true,
    };

    /// <summary>
    ///     Represents the default toolbar configuration for the Vditor editor.
    /// </summary>
    public static MenuItem[] DefaultToolBar =
    [
        Emoji,
        Headings,
        Bold,
        Italic,
        Strike,
        Link,
        Delimiter,
        List,
        OrderedList,
        Check,
        Outdent,
        Indent,
        Delimiter,
        Quote,
        Line,
        Code,
        InlineCode,
        InsertBefore,
        InsertAfter,
        Delimiter,
        Upload,
        Record,
        Table,
        Delimiter,
        Undo,
        Redo,
        Delimiter,
        Fullscreen,
        EditMode,
        new()
        {
            Name = "more",
            Toolbar =
            [
                Both,
                CodeTheme,
                ContentTheme,
                Export,
                Outline,
                Preview,
                Devtools,
                Info,
                Help,
            ],
        },
    ];
}

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

        writer.WriteEndObject();
    }
}
