namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

// public class ContentTypeEnum : Enumeration
// {
//     public static ContentTypeEnum Markdown = new(0, "markdown");
//     public static ContentTypeEnum Text = new(1, "text");
//
//     public ContentTypeEnum(int id, string name)
//         : base(id, name)
//     {
//     }
// }
[JsonConverter(typeof(JsonStringEnumConverter<ContentTypeEnum>))]
public enum ContentTypeEnum
{
    [JsonStringEnumMemberName("markdown")] Markdown = 0,
    [JsonStringEnumMemberName("text")] Text = 1,
}
