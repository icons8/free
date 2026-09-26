namespace Free.Schema;

/// <summary>
/// Text Style
/// </summary>
public class TextStyle : StyleBase
{
    /// <summary>
    /// Text font.
    /// </summary>
    public string Font { get; set; } = "Inter-Regular";
    
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
    /// Line spacing.
    /// </summary>
    public float? LineHeight { get; set; }

    /// <summary>
    /// If there is a single color fill, use this; otherwise use Fills.
    /// </summary>
    public Color Fill { get; set; }

    /// <summary>
    /// List of text fills.
    /// </summary>
    public List<Fill> Fills { get; } = new();

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
    /// If the text is underlined.
    /// </summary>
    public bool Underline { get; set; }
    
    /// <summary>
    /// If the strikethrough option is applied to the text.
    /// </summary>
    public bool Strikethrough { get; set; }
    
    /// <summary>
    /// Character case.
    /// </summary>
    public CharacterCasing Casing { get; set; }

    /// <summary>
    /// Text position against the baseline.
    /// </summary>
    public BaselinePosition BaselinePos { get; set; }

    /// <summary>
    /// If the text is RTL.
    /// </summary>
    public bool Rtl { get; set; }

    /// <summary>
    /// Variable font coordinates keyed by four-character OpenType axis tags.
    /// </summary>
    public Dictionary<string, float>? Variation { get; set; }

    /// <summary>
    /// Optical sizing mode: manual or auto.
    /// </summary>
    public string FontOpticalSizing { get; set; } = "manual";
}
