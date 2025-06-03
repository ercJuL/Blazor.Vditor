// <copyright file="PreviewThemeOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

/// <summary>
///     Represents the configuration options for the preview theme in the Vditor editor.
/// </summary>
public class PreviewThemeOption
{
    /// <summary>
    ///     Gets or sets the current preview theme.
    /// </summary>
    public required string Current { get; set; }

    /// <summary>
    ///     Gets or sets the list of available preview themes.
    /// </summary>
    /// <remarks>
    ///     Default is <c>{ "ant-design": "Ant Design", dark: "Dark", light: "Light", wechat: "WeChat" }</c>.
    /// </remarks>
    public IDictionary<string, string>? List { get; set; }

    /// <summary>
    ///     Gets or sets the path to the preview theme resources.
    /// </summary>
    /// <remarks>
    ///     Default is <c>https://unpkg.com/vditor@${VDITOR_VERSION}/dist/css/content-theme</c>.
    /// </remarks>
    public string? Path { get; set; }
}
