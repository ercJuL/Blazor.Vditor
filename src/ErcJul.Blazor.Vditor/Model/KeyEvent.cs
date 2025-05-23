namespace ErcJul.Blazor.Vditor.Model;

/// <summary>
///     Represents a keyboard event with various properties describing the event's state.
/// </summary>
public record KeyEvent
{
    /// <summary>
    ///     Gets or sets a value indicating whether the event is trusted.
    /// </summary>
    public bool IsTrusted { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the Alt key was pressed during the event.
    /// </summary>
    public bool AltKey { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the event bubbles up through the DOM.
    /// </summary>
    public bool Bubbles { get; set; }

    /// <summary>
    ///     Gets or sets the code of the key that triggered the event.
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the Ctrl key was pressed during the event.
    /// </summary>
    public bool CtrlKey { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the event is part of a composition session.
    /// </summary>
    public bool IsComposing { get; set; }

    /// <summary>
    ///     Gets or sets the key value of the key that triggered the event.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    ///     Gets or sets the location of the key on the keyboard.
    /// </summary>
    public int Location { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the Meta key was pressed during the event.
    /// </summary>
    public bool MetaKey { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the key is being held down, causing the event to repeat.
    /// </summary>
    public bool Repeat { get; set; }

    /// <summary>
    ///     Gets or sets a value indicating whether the Shift key was pressed during the event.
    /// </summary>
    public bool ShiftKey { get; set; }

    /// <summary>
    ///     Gets or sets the time stamp of the event in milliseconds.
    /// </summary>
    public double TimeStamp { get; set; }
}
