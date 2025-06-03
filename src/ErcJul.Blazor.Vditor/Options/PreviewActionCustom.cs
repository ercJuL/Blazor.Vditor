// <copyright file="PreviewActionCustom.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Options;

using System.Diagnostics;
using System.Text.Json.Serialization;

/// <summary>
///     Represents a custom preview action configuration for the Vditor editor.
/// </summary>
/// <remarks>
///     <see href="https://ld246.com/article/1549638745630#options-preview-actions">vditor.options-preview-actions</see>.
/// </remarks>
[JsonConverter(typeof(PreviewActionCustomConvert))]
public class PreviewActionCustom
{
    /// <summary>
    ///     Gets or sets the CSS class name for the button.
    /// </summary>
    public string? ClassName { get; set; }

    /// <summary>
    ///     Gets or sets the callback function to be executed when the button is clicked.
    /// </summary>
    [JsonIgnore]
    public required Func<string, Task> Click { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the action is a system-defined action.
    /// </summary>
    /// <seealso cref="SystemPreviewAction" />
    [JsonIgnore]
    public bool IsSystem { get; set; }

    /// <summary>
    ///     Gets or sets the key name of the action.
    /// </summary>
    public required string Key { get; set; }

    /// <summary>
    ///     Gets or sets the button text for the action.
    /// </summary>
    public required string Text { get; set; }

    /// <summary>
    ///     Gets or sets the tooltip text for the button.
    /// </summary>
    public string? Tooltip { get; set; }

    /// <summary>
    ///     Registers a custom preview action in the provided callback map.
    /// </summary>
    /// <param name="callbackMap">
    ///     A reference to the dictionary that maps action keys to their corresponding callback functions.
    /// </param>
    /// <remarks>
    ///     This method adds the current action to the callback map if it is not a system-defined action.
    ///     An assertion ensures that the provided callback map is not null.
    /// </remarks>
    public void Register(ref Dictionary<string, Func<string, Task>> callbackMap)
    {
        Debug.Assert(callbackMap != null, nameof(callbackMap) + " != null");
        if (!this.IsSystem)
        {
            callbackMap.Add(this.Key, this.Click);
        }
    }
}
