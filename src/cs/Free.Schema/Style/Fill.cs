namespace Free.Schema;
/// <summary>
/// Defines the fill applied to a layer.
/// </summary>

public class Fill
{
    /// <summary>
    /// If a fill is added.
    /// </summary>
    public bool Enabled { get; set; }
    /// <summary>
    /// Fill color.
    /// </summary>
    public Color Color { get; set; }
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid? ColorId { get; set; }
    /// <summary>
    /// Defines the fill type.
    /// </summary>
    public FillType Type { get; set; }
    /// <summary>
    /// Defines the fill opacity.
    /// </summary>
    public float Opacity { get; set; }
    /// <summary>
    /// Defines the blend mode.
    /// </summary>
    public BlendMode BlendMode { get; set; } 
    /// <summary>
    /// Defines the pattern for image fills: tile, stretch, etc.
    /// </summary>
    public Pattern Pattern { get; } = new();
    /// <summary>
    /// If the fill is a gradient. ????
    /// </summary>
    public Gradient Gradient { get; } = new();
}