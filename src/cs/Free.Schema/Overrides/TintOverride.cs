namespace Free.Schema;

public sealed class TintOverride : NodeOverride
{
    public Color Color { get; set; }
    public Guid? ColorId { get; set; }

    public override OverrideType Type => OverrideType.Tint;
}