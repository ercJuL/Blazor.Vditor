// <copyright file="MenuItem.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor;

using System.Diagnostics;
using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Model;
using ErcJul.Blazor.Vditor.Options;

/// <summary>
///     Represents a menu item in the Vditor editor.
/// </summary>
/// <remarks>
///     This class defines the properties and behavior of a menu item, including its name, icon, tooltip,
///     and other attributes. It also supports nested toolbars and click event handling.
/// </remarks>
/// <seealso href="https://ld246.com/article/1549638745630#options-toolbar">vditor.options-toolbar</seealso>
[JsonConverter(typeof(MenuItemJsonConverter))]
public class MenuItem
{
    /// <summary>
    ///     Gets or sets the CSS class name for the menu item.
    /// </summary>
    [JsonPropertyName("className")]
    public string? ClassName { get; set; }

    /// <summary>
    ///     Gets or sets the hotkey associated with the menu item. Don't support WYSIWYG edit type.
    /// </summary>
    /// <example>
    ///     ⌘/ctrl-key or ⌘/ctrl-⇧/shift-key.
    /// </example>
    [JsonPropertyName("hotKey")]
    public string? Hotkey { get; set; }

    /// <summary>
    ///     Gets or sets the icon associated with the menu item. It's Svg icon.
    /// </summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether this menu item is a default item.
    /// </summary>
    /// <seealso cref="DefaultMenuItem" />
    [JsonIgnore]
    public bool IsDefault { get; set; }

    /// <summary>
    ///     Gets or sets the hierarchical level of the menu item.
    /// </summary>
    [JsonPropertyName("level")]
    public uint? Level { get; set; }

    /// <summary>
    ///     Gets or sets the name of the menu item.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    ///     Gets or sets the action to be executed when the menu item is clicked.
    /// </summary>
    [JsonIgnore]
    public Func<Task>? OnClick { get; set; }// TODO: Add event parameters Action<EventArgs, IVditor>

    /// <summary>
    ///     Gets or sets the prefix text for insert content.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    ///     Gets or sets the suffix text for insert content.
    /// </summary>
    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }

    /// <summary>
    ///     Gets or sets the nested toolbar items for this menu item.
    /// </summary>
    [JsonPropertyName("toolbar")]
    public List<MenuItem>? Toolbar { get; set; }

    /// <summary>
    ///     Gets or sets the tooltip text for the menu item.
    /// </summary>
    [JsonPropertyName("tooltip")]
    public string? Tooltip { get; set; }

    /// <summary>
    ///     Gets or sets the tooltip position for the menu item.
    /// </summary>
    /// <seealso cref="TooltipPositionEnum" />
    [JsonPropertyName("tipPosition")]
    public TooltipPositionEnum? TooltipPosition { get; set; }

    /// <summary>
    ///     Registers the menu item and its nested toolbar items into the callback map.
    /// </summary>
    /// <param name="callbackMap">The dictionary to store menu item callbacks.</param>
    public void Register(ref Dictionary<string, Func<Task>> callbackMap)
    {
        Debug.Assert(callbackMap != null, nameof(callbackMap) + " != null");
        if (!this.IsDefault && this.OnClick is not null)
        {
            callbackMap.Add(this.Name, this.OnClick);
        }

        if (this.Toolbar is null)
        {
            return;
        }

        foreach (var item in this.Toolbar)
        {
            item.Register(ref callbackMap);
        }
    }
}
