// <copyright file="UploadOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

/// <summary>
///     Represents the upload options for the Vditor editor.
/// </summary>
public class UploadOption
{
    /// <summary>
    ///     Gets or sets the accepted file types for upload.
    /// </summary>
    public string? Accept { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to handle upload errors.
    /// </summary>
    public Func<string, Task>? Error { get; set; }

    /// <summary>
    ///     Gets or sets additional data to be sent with the upload request.
    /// </summary>
    public Dictionary<string, string>? ExtraData { get; set; }

    /// <summary>
    ///     Gets or sets the name of the form field for the uploaded file.
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to generate a custom filename for the uploaded file.
    /// </summary>
    public Func<string, Task<string>>? Filename { get; set; }

    /// <summary>
    ///     Gets or sets the headers to be included in the upload request.
    /// </summary>
    public Dictionary<string, string>? Headers { get; set; }

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

    /// <summary>
    ///     Gets or sets the callback function for processing the server response to generate image links.
    /// </summary>
    public Func<string, Task>? LinkToImgCallback { get; set; }

    /// <summary>
    ///     Gets or sets the URL for generating image links from the server response.
    /// </summary>
    public string? LinkToImgUrl { get; set; }

    /// <summary>
    ///     Gets or sets the maximum number of files allowed for upload.
    /// </summary>
    public uint? Max { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether multiple file uploads are allowed.
    /// </summary>
    public bool? Multiple { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to dynamically set headers for the upload request.
    /// </summary>
    public Func<Dictionary<string, string>>? SetHeaders { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to handle successful uploads.
    /// </summary>
    public Func<string, Task>? Success { get; set; }// TODO element

    // public Func<> // TODO renderLinkDest

    /// <summary>
    ///     Gets or sets the token to be included in the upload request for authentication.
    /// </summary>
    public string? Token { get; set; }

    /// <summary>
    ///     Gets or sets the URL to which the files will be uploaded.
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether credentials should be included in the upload request.
    /// </summary>
    public bool? WithCredentials { get; set; }
}
