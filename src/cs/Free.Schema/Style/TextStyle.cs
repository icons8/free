namespace Free.Schema;

public sealed class TextStyle
{
    public Color Color { get; set; } = new Color(0, 0, 0);
    /// <summary>
    /// Color Variable ID
    /// </summary>
    public Guid? ColorId { get; set; }

    public string Font { get; set; } = "Inter";
    public float Size { get; set; } = 12;

    public float ParagraphSpacing { get; set; }

    public float Kerning { get; set; }

    public float BaselineOffset { get; set; }

    public float? LineHeight { get; set; }

    public CharacterCasing Casing { get; set; }
    
    public TextHorizontalAlignment Align { get; set; }

    public TextVerticalAlignment Valign { get; set; }

    public ListMarkerType List { get; set; }

    /// <summary>
    /// todo
    /// </summary>
    public Dictionary<string, double>? Variation { get; set; }
    
    public bool RTL { get; set; }
    public bool Underline { get; set; }
    public bool Strikethrough { get; set; }

    public BaselinePosition BaselinePos { get; set; }
}