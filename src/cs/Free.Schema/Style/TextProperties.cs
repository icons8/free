namespace Free.Schema;
/// <summary>
/// Defines a set of properties that make up a text style.
/// </summary>
public sealed class TextProperties
{
    /// <summary>
    /// Text color.
    /// </summary>
    public Color Color { get; set; } = new Color(0, 0, 0);
    
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid? ColorId { get; set; }
    
    /// <summary>
    /// Text font.
    /// </summary>
    public string Font { get; set; } = "Inter";
    
    /// <summary>
    /// Text size.
    /// </summary>
    public float Size { get; set; } = 12;
    
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
    public bool RTL { get; set; }
    
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