namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
///     Represents a custom preview action configuration for the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options-preview-actions">vditor.options-preview-actions</see>.
/// </remarks>
[JsonSerializable(typeof(PreviewActionCustomConvert))]
public class PreviewActionCustom
{
    /// <summary>
    ///     Gets or sets a value indicating whether the action is a system-defined action.
    /// </summary>
    /// <seealso cref="SystemPreviewAction" />
    public bool IsSystem { get; set; }

    /// <summary>
    ///     Gets or sets the key name of the action.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    ///     Gets or sets the button text for the action.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    ///     Gets or sets the CSS class name for the button.
    /// </summary>
    public string? ClassName { get; set; }

    /// <summary>
    ///     Gets or sets the tooltip text for the button.
    /// </summary>
    public string? Tooltip { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be executed when the button is clicked.
    /// </summary>
    public Action<string> Click { get; set; }
}

/// <summary>
///     Provides predefined system preview actions for the Vditor editor.
/// </summary>
public static class SystemPreviewAction
{
    /// <summary>
    ///     Represents the desktop preview action.
    /// </summary>
    public static PreviewActionCustom Desktop = new()
    {
        IsSystem = true,
        Key = "desktop",
    };

    /// <summary>
    ///     Represents the tablet preview action.
    /// </summary>
    public static PreviewActionCustom Tablet = new()
    {
        IsSystem = true,
        Key = "tablet",
    };

    /// <summary>
    ///     Represents the mobile preview action.
    /// </summary>
    public static PreviewActionCustom Mobile = new()
    {
        IsSystem = true,
        Key = "mobile",
    };

    /// <summary>
    ///     Represents the WeChat Mini Program preview action.
    /// </summary>
    public static PreviewActionCustom MpWechat = new()
    {
        IsSystem = true,
        Key = "mp-wechat",
    };

    /// <summary>
    ///     Represents the Zhihu preview action.
    /// </summary>
    public static PreviewActionCustom Zhihu = new()
    {
        IsSystem = true,
        Key = "zhihu",
    };
}

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

        writer.WriteEndObject();
    }
}
