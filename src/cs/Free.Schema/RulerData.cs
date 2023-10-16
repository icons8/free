namespace Free.Schema;

public class Rulers
{
    /// <summary>
    /// Origin for Rulers. Not supported in Lunacy. Sketch Compatibility
    /// </summary>
    public Point Origin { get; set; }
    /// <summary>
    /// Vertical Guides positions on Horizontal Ruler
    /// </summary>
    public List<int> Guides { get; set; } = new();
    /// <summary>
    /// Horizontal Guides positions on Vertical Ruler
    /// </summary>
    public List<int> VGuides { get; set; } = new();
}