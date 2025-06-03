// <copyright file="HintExtendOption.cs" company="ercjul">
// Copyright (c) ErcJul.Blazor.Vditor Authors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace ErcJul.Blazor.Vditor.Model;

using System.Diagnostics;
using System.Text.Json.Serialization;
using ErcJul.Blazor.Vditor.Options;

/// <summary>
///     Represents the extended hint options for the Vditor editor.
/// </summary>
[JsonConverter(typeof(HintExtendOptionJsonConverter))]
public class HintExtendOption
{
    /// <summary>
    ///     Gets or sets a function that provides a list of hint data asynchronously based on a given key.
    /// </summary>
    /// <remarks>
    ///     The function takes a string as input and returns a task that resolves to a list of <see cref="HintData" /> objects.
    /// </remarks>
    [JsonIgnore]
    public Func<string, Task<List<HintData>>>? Hint { get; set; }

    /// <summary>
    ///     Gets or sets the key associated with the extended hint option.
    /// </summary>
    public required string Key { get; set; }

    /// <summary>
    ///     Registers the hint callback function in the provided callback map.
    /// </summary>
    /// <param name="callbackMap">
    ///     A reference to the dictionary that maps keys to hint callback functions.
    ///     This dictionary must not be null.
    /// </param>
    /// <remarks>
    ///     If the <see cref="Hint" /> property is not null, the method adds the key-value pair
    ///     consisting of <see cref="Key" /> and <see cref="Hint" /> to the callback map.
    /// </remarks>
    /// <exception cref="System.Diagnostics.Debug.Assert(bool, string)">
    ///     Throws an assertion failure if <paramref name="callbackMap" /> is null.
    /// </exception>
    public void Register(ref Dictionary<string, Func<string, Task<List<HintData>>>> callbackMap)
    {
        Debug.Assert(callbackMap != null, nameof(callbackMap) + " != null");

        if (this.Hint is not null)
        {
            callbackMap.Add(this.Key, this.Hint);
        }
    }
}
