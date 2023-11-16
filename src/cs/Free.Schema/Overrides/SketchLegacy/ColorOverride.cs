namespace Free.Schema;
/// <summary>
/// Defines color overrides for components.
/// </summary>

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
    /// Fill index. Starts from 0.
    /// </summary>
    public int Index { get; set; }
}