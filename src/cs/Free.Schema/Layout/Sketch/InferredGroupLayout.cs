namespace Free.Schema;

public class InferredGroupLayout : GroupLayoutBase
{
    public GroupLayoutAxis Axis { get; set; } = GroupLayoutAxis.Horizontal;
    public GroupLayoutAnchor LayoutAnchor { get; set; } = GroupLayoutAnchor.Begin;
    public float MaxSize { get; set; }
    public float MinSize { get; set; }
}