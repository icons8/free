namespace Free.Schema;

public sealed class TextStyle
{
    public float ResultFontSize => FontSize * (BaselinePosition == BaselinePosition.Normal ? 1 : 0.6f);

    public Color Color { get; set; } = new Color(0, 0, 0);

    public Guid? ColorId { get; set; }

    public string FontFamilyName { get; set; } = "Inter";

    public float FontSize { get; set; } = 12;

    public float ParagraphSpacing { get; set; }

    public float LetterSpacing { get; set; }

    public float BaselineOffset { get; set; }

    private float? _lineHeight;
    public float? LineHeight
    {
        get => _lineHeight;
        set => _lineHeight = IsAutoLineHeight || value < 1 ? null : value;
    }

    public CharacterCasing CharacterCasing { get; set; }
    
    public TextHorizontalAlignment HorizontalAlignment { get; set; }

    public TextVerticalAlignment VerticalAlignment { get; set; }

    public ListMarkerType ListMarkerType { get; set; }

    public Dictionary<string, double>? FontVariation { get; set; }
    
    public bool IsRTL { get; set; }
    public bool IsWrap { get; set; }
    public bool IsAutoLineHeight { get; set; }
    public bool Underline { get; set; }
    public bool Strikethrough { get; set; }

    public BaselinePosition BaselinePosition { get; set; }
}