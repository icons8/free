namespace Free.Schema;
/// <summary>
/// A shape is a rectangle, oval, polygon, triangle, or star drawn with the respective shape tool. You can draw a triangle, rectangle, etc. with the Pen tool, but they won't be treated as shapes.
/// </summary>

public class Shape : Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "SHAPE";
    /// <summary>
    /// Determines the appearance of the tail of an open path drawn with the Line, Arrow, or Pen/Pencil tool. 
    /// </summary>
    public Arrowhead TailMarker { get; set; }
    /// <summary>
    /// Determines the appearance of the head of an open path drawn with the Line, Arrow, or Pen/Pencil tool.
    /// </summary>
    public Arrowhead HeadMarker { get; set; }
    /// <summary>
    /// Limit on the ratio of the miter length to the stroke-width used to draw a miter joint. When the limit is exceeded, the joint is converted from miter to beveled.
    /// </summary>
    public float MiterLimit { get; set; } = 10;
    /// <summary>
    /// Serves for constraints compatibility with Sketch. If the file is imported from the Sketch format, the parameter should be set to false to handle constraints properly.
    /// </summary>
    [SketchCompatibility]
    public bool SkipConstraints { get; set; }
    /// <summary>
    /// List of layers.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}