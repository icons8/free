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
    /// Color Style Id.
    /// </summary>
    public Guid FillsId { get; set; }
    
    /// <summary>
    /// Text style id.
    /// </summary>
    public Guid TextStyleId { get; set; }
    
    /// <summary>
    /// List of fills.
    /// </summary>
    public List<Fill> Fills { get; } = new();
    
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
}