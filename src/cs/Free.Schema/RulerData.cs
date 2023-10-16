namespace Free.Schema;

/// <summary>
/// Object containing rulers origin and guidelines positions
/// </summary>
public class Rulers
{
    /// <summary>
    /// Origin for Rulers. Not supported in Lunacy. Sketch Compatibility
    /// </summary>
    public Point Origin { get; set; }
    /// <summary>
    /// Vertical guidelines positions on Horizontal Ruler
    /// </summary>
    public List<int> Guides { get; set; } = new();
    /// <summary>
    /// Horizontal guidelines positions on Vertical Ruler
    /// </summary>
    public List<int> VGuides { get; set; } = new();
}