namespace Free.Schema;
/// <summary>
/// Defines text color overrides for components.
/// </summary>

[SketchCompatibility]
public sealed class TextColorOverride
{
    /// <summary>
    /// Color value.
    /// </summary>
    public Color Color { get; set; }
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid? ColorId { get; set; }
}