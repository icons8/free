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
    /// Text offset from the baseline.
    /// </summary>
    public float BaselineOffset { get; set; }
    
    /// <summary>
    /// Line spacing.
    /// </summary>
    public float? LineHeight { get; set; }
    
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
    /// Variable fonts settings. Not supported in Lunacy yet.
    /// </summary>
    public Dictionary<string, float>? Variation { get; set; }
}