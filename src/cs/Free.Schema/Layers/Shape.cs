namespace Free.Schema;

public class Shape : Styled
{
    public override string _t => "SHAPE";
    
    /// <summary>
    /// This is for constraints compatibility with sketch. If file is imported from sketch format it should be false to handle constraints properly.
    /// </summary>
    [SketchCompatibility]
    public bool SkipConstraints { get; set; }
    /// <summary>
    /// Sketch Group Layout. We don't support it but keep it for compatibility
    /// </summary>
    [SketchCompatibility]
    public IGroupLayout? GroupLayout { get; set; }
    public List<Layer> Layers { get; } = new();
}