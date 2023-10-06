namespace Free.Schema;

public class InstanceLayer : BoxLayer
{
    public float Scale { get; set; }
    public Guid ComponentId { get; set; }
    public float VerticalSpacing { get; set; }
    public float HorizontalSpacing { get; set; }
    public List<NodeOverride> Overrides { get; } = new();
}