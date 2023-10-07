namespace Free.Schema;

public sealed class TextColorOverride : NodeOverride
{
    public Color Color { get; set; }
    public Guid? ColorId { get; set; }

    public override OverrideType Type => OverrideType.TextColor;
}