namespace Free.Schema;
/// <summary>
/// Defines how a text is aligned horizontally.
/// </summary>
public enum TextHorizontalAlignment : byte
{
    /// <summary>
    /// Text is aligned to the left.
    /// </summary>
    Left = 0,
    /// <summary>
    /// Text is aligned to the right.
    /// </summary>
    Right = 1,
    /// <summary>
    /// Text is horizontally centered.
    /// </summary>
    Center = 2,
    /// <summary>
    /// Text is horizontally justified.
    /// </summary>
    Justify = 3,
    /// <summary>
    /// No explicit horizontal alignment.
    /// </summary>
    None = 4,
    /// <summary>
    /// Text is aligned to the logical start edge.
    /// </summary>
    Start = 5,
    /// <summary>
    /// Text is aligned to the logical end edge.
    /// </summary>
    End = 6,
    /// <summary>
    /// Alignment is detected from the text content.
    /// </summary>
    DetectFromContent = 7,
}
