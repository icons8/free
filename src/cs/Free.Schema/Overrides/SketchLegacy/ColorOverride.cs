namespace Free.Schema;

public sealed class ColorOverride
{
    public Color Color { get; set; }
    public Guid? ColorId { get; set; }
    public ColorOverrideType Property { get; set; }
    public int Index { get; set; }
}