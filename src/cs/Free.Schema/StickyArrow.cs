namespace Free.Schema;

/// <summary>
/// Sticky Arrows are used for annotations. Stored on a page. Not a layer.
/// </summary>
public sealed class StickyArrow
{
    /// <summary>
    /// Tail Layer Id
    /// </summary>
    public Guid? Start { get; set; }
    
    /// <summary>
    /// Head Layer Id
    /// </summary>
    public Guid? End { get; set; }
    
    /// <summary>
    /// Normalized position in the tail layer. From 0 to 1.
    /// </summary>
    public Point StartPos { get; set; }
    
    /// <summary>
    /// Normalized position in the head layer. From 0 to 1.
    /// </summary>
    public Point EndPos { get; set; }
    
    /// <summary>
    /// Determines the appearance of the tail.
    /// </summary>
    public Arrowhead StartMarker { get; set; }
    
    /// <summary>
    /// Determines the appearance of the head.
    /// </summary>
    public Arrowhead EndMarker { get; set; }
    
    /// <summary>
    /// Defines the shape of line caps.
    /// </summary>
    public LineCap LineCap { get; set; } = LineCap.Butt;
    
    /// <summary>
    /// Defines the appearance of line folds.
    /// </summary>
    public LineJoin LineJoin { get; set; } = LineJoin.Miter;
    
    /// <summary>
    /// Defines the size of dashes.
    /// </summary>
    public float[] Dash { get; set; } = [];
    
    /// <summary>
    /// Defines border thickness.
    /// </summary>
    public float Thickness { get; set; }
    
    /// <summary>
    /// Color of the Arrow
    /// </summary>
    public Color Color { get; set; }
}