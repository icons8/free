namespace Free.Schema;

/// <summary>
/// Connectors are lines and arrows used for annotations.
/// </summary>
public sealed class Connector : Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "CONNECTOR";
    
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
    /// Limit on the ratio of the miter length to the stroke-width used to draw a miter joint. When the limit is exceeded, the joint is converted from miter to beveled.
    /// </summary>
    public float MiterLimit { get; set; } = 10;
}