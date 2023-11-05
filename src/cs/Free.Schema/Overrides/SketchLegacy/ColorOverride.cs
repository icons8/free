namespace Free.Schema;

[SketchCompatibility]
public sealed class ColorOverride
{
    public Color Color { get; set; }
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid? ColorId { get; set; }
    /// <summary>
    /// Color override type: none, fill, border, shadow, or inner shadow.
    /// </summary>
    public ColorOverrideType Property { get; set; }
    /// <summary>
    /// ????
    /// </summary>
    public int Index { get; set; }
}