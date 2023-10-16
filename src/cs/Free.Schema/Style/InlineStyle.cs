namespace Free.Schema;

/// <summary>
/// Style of text part
/// </summary>
public class InlineStyle
{
    /// <summary>
    /// selection start position
    /// </summary>
    public int Start { get; set; }

    /// <summary>
    /// length of selection
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// Selection style
    /// </summary>
    public TextStyle Style { get; } = new();
}