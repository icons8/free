namespace Free.Schema;

public class ShapeGroup : Styled
{
    public bool SkipConstraints { get; set; }
    public IGroupLayout? GroupLayout { get; set; }
    public List<Layer> Layers { get; } = new();
}