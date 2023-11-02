namespace Free.Schema;
/// <summary>
/// Defines the image fill options.
/// </summary>
public class Pattern
{
    /// <summary>
    /// Defines the fill type: tile, fill, stretch, fit, or crop.
    /// </summary>
    public PatternFillType Type { get; set; } = PatternFillType.Fill;
    /// <summary>
    /// Defines the image used as a fill.???? path/id or what???
    /// </summary>
    public string? Image { get; set; }
    
    /// <summary>
    /// Image rotation value, in degrees. Applicable to all types, except for crop.
    /// </summary>
    public float Rotation { get; set; }
    
    /// <summary>
    /// Tile scale value. Applicable to the tile type only.
    /// </summary>
    public float TileScale { get; set; } = 1;
    
    /// <summary>
    /// Defines how the image is cropped. Applicable to the crop type only.
    /// </summary>
    public Matrix? Transform { get; set; }
}