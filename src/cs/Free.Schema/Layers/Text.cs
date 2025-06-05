namespace Free.Schema;
/// <summary>
/// Text is a block or line of text on the canvas.
/// </summary>

public class Text : Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "TEXT";
    /// <summary>
    /// Content of the text layer.
    /// </summary>
    public string text { get; set; }
    /// <summary>
    /// Style applied to the text.
    /// </summary>
    public TextProperties TextStyle { get; } = new();
    /// <summary>
    /// Styling options applied to the text within a text block. 
    /// </summary>
    public List<InlineStyle> Inlines { get; } = new();
    /// <summary>
    /// Behavior of the text layer size on text value change: flexible, fixed-width, or fixed.
    /// </summary>
    public TextBehavior Behavior { get; set; } = TextBehavior.Flexible;
    /// <summary>
    /// Valid for files imported from Figma. Defines whether to truncate text content.
    /// </summary>
    public bool ClipContent { get; set; } = true;
    /// <summary>
    /// Trim text with triple dots in the end if content overlaps fixed layer size bounds.
    /// </summary>
    public bool Truncate { get; set; } = false;
    /// <summary>
    /// Count of lines allowed. If the limit is exceeded, the text will be truncated.
    /// </summary>
    public byte MaxLines { get; set; } = 0;
    /// <summary>
    /// Defines whether text draws on the underlying path.
    /// </summary>
    public bool DrawOnPath { get; set; } = false;
    /// <summary>
    /// Defines whether text warps when drawn on the underlying path.
    /// </summary>
    public bool Warp { get; set; } = false;
    /// <summary>
    /// Text style id.
    /// </summary>
    public Guid PropsId { get; set; }
}