namespace Free.Schema;

/// <summary>
/// An object containing ruler origins and guideline positions.
/// </summary>
public class Rulers
{
    /// <summary>
    /// Ruler origin. Not supported in Lunacy. Sketch Compatibility
    /// </summary>
    [SketchCompatibility]
    public Point Origin { get; set; }
    /// <summary>
    /// Positions of vertical guidelines on the Horizontal Ruler.
    /// </summary>
    public List<int> Guides { get; set; } = new();
    /// <summary>
    /// Positions of horizontal guidelines on the Vertical Ruler.
    /// </summary>
    public List<int> VGuides { get; set; } = new();
}