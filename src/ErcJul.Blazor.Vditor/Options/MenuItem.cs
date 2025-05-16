namespace ErcJul.Blazor.Vditor;

using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;

[JsonConverter(typeof(MenuItemJsonConverter))]
public class MenuItem
{
    [JsonIgnore]
    public bool IsDefault { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    [JsonPropertyName("className")]
    public string? ClassName { get; set; }

    [JsonPropertyName("tooltip")]
    public string? Tooltip { get; set; }

    [JsonPropertyName("hotKey")]
    public string? Hotkey { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("tipPosition")]
    public TooltipPositionEnum? TooltipPosition { get; set; }

    [JsonPropertyName("toolbar")]
    public List<MenuItem>? Toolbar { get; set; }

    [JsonPropertyName("level")]
    public uint? Level { get; set; }

    [JsonIgnore]
    public Action? OnClick { get; set; }// TODO 事件参数 Action<EventArgs, IVditor>

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

public static class DefaultMenuItem
{
    public static readonly MenuItem Export = new()
    {
        Name = "export",
        IsDefault = true,
    };

    public static readonly MenuItem Emoji = new()
    {
        Name = "emoji",
        IsDefault = true,
    };

    public static readonly MenuItem Headings = new()
    {
        Name = "headings",
        IsDefault = true,
    };

    public static readonly MenuItem Bold = new()
    {
        Name = "bold",
        IsDefault = true,
    };

    public static readonly MenuItem Italic = new()
    {
        Name = "italic",
        IsDefault = true,
    };

    public static readonly MenuItem Strike = new()
    {
        Name = "strike",
        IsDefault = true,
    };

    public static readonly MenuItem Link = new()
    {
        Name = "link",
        IsDefault = true,
    };

    public static readonly MenuItem List = new()
    {
        Name = "list",
        IsDefault = true,
    };

    public static readonly MenuItem OrderedList = new()
    {
        Name = "ordered-list",
        IsDefault = true,
    };

    public static readonly MenuItem Check = new()
    {
        Name = "check",
        IsDefault = true,
    };

    public static readonly MenuItem Outdent = new()
    {
        Name = "outdent",
        IsDefault = true,
    };

    public static readonly MenuItem Indent = new()
    {
        Name = "indent",
        IsDefault = true,
    };

    public static readonly MenuItem Quote = new()
    {
        Name = "quote",
        IsDefault = true,
    };

    public static readonly MenuItem Line = new()
    {
        Name = "line",
        IsDefault = true,
    };

    public static readonly MenuItem Code = new()
    {
        Name = "code",
        IsDefault = true,
    };

    public static readonly MenuItem InlineCode = new()
    {
        Name = "inline-code",
        IsDefault = true,
    };

    public static readonly MenuItem InsertBefore = new()
    {
        Name = "insert-before",
        IsDefault = true,
    };

    public static readonly MenuItem InsertAfter = new()
    {
        Name = "insert-after",
        IsDefault = true,
    };

    public static readonly MenuItem Upload = new()
    {
        Name = "upload",
        IsDefault = true,
    };

    public static readonly MenuItem Record = new()
    {
        Name = "record",
        IsDefault = true,
    };

    public static readonly MenuItem Table = new()
    {
        Name = "table",
        IsDefault = true,
    };

    public static readonly MenuItem Undo = new()
    {
        Name = "undo",
        IsDefault = true,
    };

    public static readonly MenuItem Redo = new()
    {
        Name = "redo",
        IsDefault = true,
    };

    public static readonly MenuItem More = new()
    {
        Name = "more",
        IsDefault = true,
    };

    public static readonly MenuItem Fullscreen = new()
    {
        Name = "fullscreen",
        IsDefault = true,
    };

    public static readonly MenuItem EditMode = new()
    {
        Name = "edit-mode",
        IsDefault = true,
    };

    public static readonly MenuItem Both = new()
    {
        Name = "both",
        IsDefault = true,
    };

    public static readonly MenuItem Preview = new()
    {
        Name = "preview",
        IsDefault = true,
    };

    public static readonly MenuItem Outline = new()
    {
        Name = "outline",
        IsDefault = true,
    };

    public static readonly MenuItem ContentTheme = new()
    {
        Name = "content-theme",
        IsDefault = true,
    };

    public static readonly MenuItem CodeTheme = new()
    {
        Name = "code-theme",
        IsDefault = true,
    };

    public static readonly MenuItem Devtools = new()
    {
        Name = "devtools",
        IsDefault = true,
    };

    public static readonly MenuItem Info = new()
    {
        Name = "info",
        IsDefault = true,
    };

    public static readonly MenuItem Help = new()
    {
        Name = "help",
        IsDefault = true,
    };

    public static readonly MenuItem Delimiter = new()
    {
        Name = "|",
        IsDefault = true,
    };

    public static readonly MenuItem Br = new()
    {
        Name = "br",
        IsDefault = true,
    };

    public static MenuItem[] DefaultToolBar =
    {
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
    };
}

public class MenuItemJsonConverter : JsonConverter<MenuItem>
{
    public override MenuItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var json = JsonDocument.ParseValue(ref reader).RootElement;
        return JsonSerializer.Deserialize<MenuItem>(json.GetRawText(), options);
    }

    public override void Write(Utf8JsonWriter writer, MenuItem value, JsonSerializerOptions options)
    {
        if (value.IsDefault)
        {
            writer.WriteStringValue(value.Name);
            return;
        }

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
