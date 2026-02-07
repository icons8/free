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
    /// Text font.
    /// </summary>
    public string Font { get; set; } = "Inter";
    /// <summary>
    /// Text size.
    /// </summary>
    public float FontSize { get; set; } = 12;
    /// <summary>
    /// Paragraph spacing.
    /// </summary>
    public float ParagraphSpacing { get; set; }
    /// <summary>
    /// Letter spacing.
    /// </summary>
    public float Kerning { get; set; }
    /// <summary>
    /// Text offset from the baseline.
    /// </summary>
    public float BaselineOffset { get; set; }
    /// <summary>
    /// Line spacing.
    /// </summary>
    public float? LineHeight { get; set; }
    /// <summary>
    /// Character case.
    /// </summary>
    public CharacterCasing Casing { get; set; }
    /// <summary>
    /// Horizontal alignment applied to the text.
    /// </summary>
    public TextHorizontalAlignment Align { get; set; }
    /// <summary>
    /// Vertical alignment applied to the text.
    /// </summary>
    public TextVerticalAlignment Valign { get; set; }
    /// <summary>
    /// List type: numbered, bulleted, none.
    /// </summary>
    public ListMarkerType List { get; set; }
    /// <summary>
    /// Variable fonts settings. Not supported in Lunacy yet.
    /// </summary>
    public Dictionary<string, float>? Variation { get; set; }
    /// <summary>
    /// If the text is RTL.
    /// </summary>
    public bool Rtl { get; set; }
    /// <summary>
    /// If the text is underlined.
    /// </summary>
    public bool Underline { get; set; }
    /// <summary>
    /// If the strikethrough option is applied to the text.
    /// </summary>
    public bool Strikethrough { get; set; }
    /// <summary>
    /// Text position against the baseline.
    /// </summary>
    public BaselinePosition BaselinePos { get; set; }
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
    public Guid TextStyleId { get; set; }
}