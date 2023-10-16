namespace Free.Schema;

public class Shape : Styled
{
    public override string _t => "SHAPE";
    
    public bool SkipConstraints { get; set; }
    public IGroupLayout? GroupLayout { get; set; }
    public List<Layer> Layers { get; } = new();
}