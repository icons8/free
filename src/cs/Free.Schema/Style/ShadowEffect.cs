namespace Free.Schema;
/// <summary>
/// Defines the shadow options.
/// </summary>
public sealed class ShadowEffect
{
    /// <summary>
    /// If a shadow effect is enabled.
    /// </summary>
    public bool Enabled { get; set; } = true;
    /// <summary>
    /// Radius of the shadow blur.
    /// </summary>
    public float Radius { get; set; }
    /// <summary>
    /// Shadow color.
    /// </summary>
    public Color Color { get; set; }
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid? ColorId { get; set; }
    /// <summary>
    /// Shadow spread value.
    /// </summary>
    public float Spread { get; set; }
    /// <summary>
    /// How far the shadow is projected in the x and y directions.
    /// </summary>
    public Point Offset { get; set; }
    /// <summary>
    /// Shadow opacity.
    /// </summary>
    public float Opacity { get; set; }
    /// <summary>
    /// Shadow blend mode.
    /// </summary>
    public BlendMode BlendMode { get; set; }
}