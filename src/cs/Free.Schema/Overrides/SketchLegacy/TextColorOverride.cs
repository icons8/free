namespace Free.Schema;
/// <summary>
/// Defines text color overrides.
/// </summary>

[SketchCompatibility]
public sealed class TextColorOverride
{
    public Color Color { get; set; }
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid? ColorId { get; set; }
}