namespace Free.Schema;

public class Instance : Styled
{
    public override string Type => "INSTANCE";
    
    public float[] CornerRadius { get; set; } = new float[4];
    public RadiusBehavior RadiusBehavior { get; set; } = RadiusBehavior.Rounded;
    public ILayoutContainer? LayoutStrategy { get; set; }
    
    public float Scale { get; set; }
    public Guid ComponentId { get; set; }
    public float VerticalSpacing { get; set; }
    public float HorizontalSpacing { get; set; }
    public List<NodeOverride> Overrides { get; } = new();
}