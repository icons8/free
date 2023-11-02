namespace Free.Schema;

/// <summary>
/// Style (bold, italic, etc.) applied to a part of text or single word within a text block.
/// </summary>
public class InlineStyle
{
    /// <summary>
    /// Position where the style starts.
    /// </summary>
    public int Start { get; set; }

    /// <summary>
    /// Length of the selection.
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// Style applied to the selection.
    /// </summary>
    public TextStyle Style { get; } = new();
}