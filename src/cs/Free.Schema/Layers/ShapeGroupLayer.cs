namespace Free.Schema;

public class ShapeGroupLayer : StyledLayer
{
    public bool SkipConstraints { get; set; }
    public GroupLayoutBase? GroupLayout { get; set; }
    public FillType Winding { get; set; }
    public List<Layer> Layers { get; } = new();
}