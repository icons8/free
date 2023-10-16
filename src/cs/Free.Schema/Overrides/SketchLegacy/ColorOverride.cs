namespace Free.Schema;

public sealed class ColorOverride
{
    public Color Color { get; set; }
    /// <summary>
    /// Color Variable ID
    /// </summary>
    public Guid? ColorId { get; set; }
    public ColorOverrideType Property { get; set; }
    public int Index { get; set; }
}