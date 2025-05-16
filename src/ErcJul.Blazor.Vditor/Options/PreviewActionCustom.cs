namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json;
using System.Text.Json.Serialization;

[JsonSerializable(typeof(PreviewActionCustomConvert))]
public class PreviewActionCustom
{
    public bool IsSystem { get; set; }

    /// <summary>
    ///     键名
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    ///     按钮文本
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    ///     按钮 className 值
    /// </summary>
    public string? ClassName { get; set; }

    /// <summary>
    ///     按钮提示信息
    /// </summary>
    public string? Tooltip { get; set; }

    /// <summary>
    ///     点击回调
    /// </summary>
    public Action<string> Click { get; set; }
}

public static class SystemPreviewAction
{
    public static PreviewActionCustom Desktop = new()
    {
        IsSystem = true,
        Key = "desktop",
    };

    public static PreviewActionCustom Tablet = new()
    {
        IsSystem = true,
        Key = "tablet",
    };

    public static PreviewActionCustom Mobile = new()
    {
        IsSystem = true,
        Key = "mobile",
    };

    public static PreviewActionCustom MpWechat = new()
    {
        IsSystem = true,
        Key = "mp-wechat",
    };

    public static PreviewActionCustom Zhihu = new()
    {
        IsSystem = true,
        Key = "zhihu",
    };
}

public class PreviewActionCustomConvert : JsonConverter<PreviewActionCustom>
{
    public override PreviewActionCustom Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var previewActionCustom = new PreviewActionCustom();
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
                    previewActionCustom.Key = reader.GetString();
                    break;
                case "text":
                    previewActionCustom.Text = reader.GetString();
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

        writer.WriteEndObject();
    }
}
