// <copyright file="AnchorEnum.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Specifies the rendering behavior for anchors in the Vditor editor.
/// </summary>
public enum AnchorEnum
{
    /// <summary>
    ///     Indicates that anchors should not be rendered.
    /// </summary>
    NoRender = 0,

    /// <summary>
    ///     Indicates that anchors should be rendered on the left side.
    /// </summary>
    RenderLeft = 1,

    /// <summary>
    ///     Indicates that anchors should be rendered on the right side.
    /// </summary>
    RenderRight = 2,
}
