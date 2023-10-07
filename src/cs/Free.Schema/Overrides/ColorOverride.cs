namespace Free.Schema;

public sealed class ColorOverride : NodeOverride
{
    public Color Color { get; set; }
    public Guid? ColorId { get; set; }
    public ColorOverrideType Property { get; set; }
    public int Index { get; set; }
    
    public override OverrideType Type => OverrideType.Color;
}