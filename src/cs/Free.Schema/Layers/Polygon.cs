namespace Free.Schema;

/// <summary>
/// A polygon is a shape drawn on the canvas with the Polygon tool.
/// </summary>
public class Polygon : Path
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "POLYGON";
    
    /// <summary>
    /// Defines the number of corners.
    /// </summary>
    public float Rays { get; set; }
}