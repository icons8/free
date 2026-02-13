namespace Free.Schema;

/// <summary>
/// A vector path determines the outline and form of a vector object. A path is made up of points and segments. 
/// </summary>
public class Path : Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "PATH";
    /// <summary>
    /// Determines the appearance of the tail of an open path drawn with the Line, Arrow, or Pen/Pencil tool. 
    /// </summary>
    public Arrowhead StartMarker { get; set; }
    /// <summary>
    /// Determines the appearance of the head of an open path drawn with the Line, Arrow, or Pen/Pencil tool.
    /// </summary>
    public Arrowhead EndMarker { get; set; }
    /// <summary>
    /// Limit on the ratio of the miter length to the stroke-width used to draw a miter joint. When the limit is exceeded, the joint is converted from miter to beveled.
    /// </summary>
    public float MiterLimit { get; set; } = 10;
    /// <summary>
    /// If the shape is edited in the path editor.
    /// </summary>
    public bool Edited { get; set; }
    /// <summary>
    /// Indicates whether the path is open.
    /// </summary>
    public bool Open { get; set; }
    /// <summary>
    /// List of path's points.
    /// </summary>
    public List<Vertex> Points { get; } = new();
    /// <summary>
    /// Optional Field. SVG path data. Overrides Points. Only for LLM and Plugins.
    /// </summary>
    public string PathData { get; set; } = "";
}