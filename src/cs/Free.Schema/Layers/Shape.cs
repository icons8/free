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
    /// Serves for constraints compatibility with Sketch. If the file is imported from the Sketch format, the parameter should be set to false to handle constraints properly.
    /// </summary>
    [SketchCompatibility]
    public bool SkipConstraints { get; set; }
    /// <summary>
    /// List of layers.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}