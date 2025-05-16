namespace ErcJul.Blazor.Vditor.Options;

using System.Text.Json.Serialization;

// public class IconEnum : Enumeration
// {
//     public static IconEnum Antd = new(0, "antd");
//     public static IconEnum Material = new(1, "material");
//
//     public IconEnum(int id, string name)
//         : base(id, name)
//     {
//     }
// }
[JsonConverter(typeof(JsonStringEnumConverter<IconEnum>))]
public enum IconEnum
{
    [JsonStringEnumMemberName("antd")] Antd = 0,
    [JsonStringEnumMemberName("material")] Material = 1,
}
