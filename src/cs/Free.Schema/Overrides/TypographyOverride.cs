namespace Free.Schema;

public sealed class TypographyOverride : NodeOverride
{
    public TextStyle TextStyle { get; } = new();
    public List<InlineStyle> Inlines { get; } = new();
    public TextBehavior TextBehavior { get; set; }
    public Size Size { get; set; }

    public override OverrideType Type => OverrideType.Typography;
}