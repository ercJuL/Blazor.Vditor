namespace ErcJul.Blazor.Vditor.Options;

public class UploadOption
{
    public string? Url { get; set; }

    public uint? Max { get; set; }

    public string LinkToImgUrl { get; set; }

    // public Func<> // TODO renderLinkDest
    public string? Token { get; set; }

    public string? Accept { get; set; }

    public bool? WithCredentials { get; set; }

    public Dictionary<string, string> Headers { get; set; }

    public Dictionary<string, string> ExtraData { get; set; }

    public bool? Multiple { get; set; }

    public string? FieldName { get; set; }

    public Func<Dictionary<string, string>>? SetHeaders { get; set; }

    public Func<string, Task>? Success { get; set; }//TODO element

    public Func<string, Task>? Error { get; set; }

    public Func<string, Task<string>>? Filename { get; set; }

    // TODO
    // /** 校验，成功时返回 true 否则返回错误信息 */
    // validate?(files: File[]): string | boolean;
    //
    // /** 自定义上传，当发生错误时返回错误信息 */
    // handler?(files: File[]): string | null | Promise<string> | Promise<null>;
    //
    // /** 对服务端返回的数据进行转换，以满足内置的数据结构 */
    // format?(files: File[], responseText: string): string;
    //
    // /** 对服务端返回的数据进行转换(对应linkToImgUrl)，以满足内置的数据结构 */
    // linkToImgFormat?(responseText: string): string;
    //
    // /** 将上传的文件处理后再返回  */
    // file?(files: File[]): File[] | Promise<File[]>;
    //
    // /** 取消正在上传的文件  */
    // cancel?(files: File[]): void;
    public Func<string, Task>? LinkToImgCallback { get; set; }
}
