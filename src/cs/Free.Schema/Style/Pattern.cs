namespace Free.Schema;

public class Pattern
{
    public PatternFillType Type { get; set; } = PatternFillType.Fill;
    public string? Image { get; set; }
    
    /// <summary>
    /// For all fill types except crop
    /// </summary>
    public float Rotation { get; set; }
    
    /// <summary>
    /// Used only for Tile
    /// </summary>
    public float TileScale { get; set; } = 1;
    
    /// <summary>
    /// Only used in Crop pattern fill type
    /// </summary>
    public Matrix? ImageTransform { get; set; }
}