namespace Free.Schema;

/// <summary>
/// Defines textbox behavior options.
/// </summary>
public enum TextBehavior : byte
{
    /// <summary>
    /// Both the width and height of the textbox automatically adjusts to fit its content. Characters do not wrap.
    /// </summary>
    Flexible = 0,
    /// <summary>
    /// The width of the textbox is fixed. Characters wrap to fit in the textbox. The height of the textbox automatically adjusts to fit its content.
    /// </summary>
    AutoHeight = 1,
    /// <summary>
    /// The size of the textbox is fixed and is independent of its content.
    /// </summary>
    Fixed = 2,
}