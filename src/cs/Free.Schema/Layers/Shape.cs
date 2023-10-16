namespace Free.Schema;

public class Shape : Styled
{
    public override string _t => "SHAPE";
    
    [SketchCompatibility]
    public bool SkipConstraints { get; set; }
    [SketchCompatibility]
    public IGroupLayout? GroupLayout { get; set; }
    public List<Layer> Layers { get; } = new();
}