namespace Free.Schema;

public class Shape : Styled
{
    public override string _t => "SHAPE";
    
    /// <summary>
    /// Serves for constraints compatibility with Sketch. If the file is imported from the Sketch format, the parameter should be set to false to handle constraints properly.
    /// </summary>
    [SketchCompatibility]
    public bool SkipConstraints { get; set; }
    /// <summary>
    /// Sketch group layout. We don't support it, but keep it for compatibility.
    /// </summary>
    [SketchCompatibility]
    public IGroupLayout? GroupLayout { get; set; }
    /// <summary>
    /// List of layers.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}