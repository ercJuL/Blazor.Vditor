// <copyright file="SystemPreviewAction.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

/// <summary>
///     Provides predefined system preview actions for the Vditor editor.
/// </summary>
public static class SystemPreviewAction
{
    /// <summary>
    ///     Represents the desktop preview action.
    /// </summary>
    public static readonly PreviewActionCustom Desktop = new()
    {
        IsSystem = true, Click = key => Task.CompletedTask,
        Key = "desktop", Text = "desktop",
    };

    /// <summary>
    ///     Represents the mobile preview action.
    /// </summary>
    public static readonly PreviewActionCustom Mobile = new()
    {
        IsSystem = true, Click = key => Task.CompletedTask,
        Key = "mobile", Text = "mobile",
    };

    /// <summary>
    ///     Represents the WeChat Mini Program preview action.
    /// </summary>
    public static readonly PreviewActionCustom MpWechat = new()
    {
        IsSystem = true, Click = key => Task.CompletedTask,
        Key = "mp-wechat", Text = "mp-wechat",
    };

    /// <summary>
    ///     Represents the tablet preview action.
    /// </summary>
    public static readonly PreviewActionCustom Tablet = new()
    {
        IsSystem = true, Click = key => Task.CompletedTask,
        Key = "tablet", Text = "tablet",
    };

    /// <summary>
    ///     Represents the Zhihu preview action.
    /// </summary>
    public static readonly PreviewActionCustom Zhihu = new()
    {
        IsSystem = true, Click = key => Task.CompletedTask,
        Key = "zhihu", Text = "zhihu",
    };
}
