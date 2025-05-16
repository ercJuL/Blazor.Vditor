namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

// public class PreviewModeEnum : Enumeration
// {
//     public static PreviewModeEnum Both = new(0, "both");
//     public static PreviewModeEnum Editor = new(1, "editor");
//
//     public PreviewModeEnum(int id, string name)
//         : base(id, name)
//     {
//     }
// }
[JsonConverter(typeof(JsonStringEnumConverter<PreviewModeEnum>))]
public enum PreviewModeEnum
{
    [JsonStringEnumMemberName("both")] Both = 0,
    [JsonStringEnumMemberName("editor")] Editor = 1,
}
