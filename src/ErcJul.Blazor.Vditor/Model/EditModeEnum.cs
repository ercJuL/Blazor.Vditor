namespace ErcJul.Blazor.Vditor.Model;

using System.Text.Json.Serialization;

// public class EditModeEnum : Enumeration
// {
//     public static EditModeEnum WYSIWYG = new(0, "wysiwyg");
//     public static EditModeEnum Sv = new(1, "sv");
//     public static EditModeEnum Ir = new(2, "ir");
//
//     public EditModeEnum(int id, string value)
//         : base(id, value)
//     {
//     }
// }
[JsonConverter(typeof(JsonStringEnumConverter<EditModeEnum>))]
public enum EditModeEnum
{
    [JsonStringEnumMemberName("wysiwyg")] WYSIWYG = 0,
    [JsonStringEnumMemberName("sv")] Sv = 1,
    [JsonStringEnumMemberName("ir")] Ir = 2,
}
