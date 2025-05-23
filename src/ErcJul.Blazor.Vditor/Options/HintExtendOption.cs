namespace ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents the extended hint options for the Vditor editor.
/// </summary>
public class HintExtendOption
{
    /// <summary>
    ///     Gets or sets the key associated with the extended hint option.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    ///     Gets or sets a function that provides a list of hint data asynchronously based on a given key.
    /// </summary>
    /// <remarks>
    ///     The function takes a string as input and returns a task that resolves to a list of <see cref="HintData" /> objects.
    /// </remarks>
    public Func<string, Task<List<HintData>>>? Hint { get; set; }
}
