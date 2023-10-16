namespace Free.Schema;

public class Instance : Styled
{
    public override string _t => "INSTANCE";
    
    /// <summary>
    /// Sets the corner radius of the instance frame.
    /// </summary>
    public float[] CornerRadius { get; set; } = new float[4];
    public RadiusBehavior RadiusBehavior { get; set; } = RadiusBehavior.Rounded;
    public ILayoutContainer? LayoutStrategy { get; set; }
    
    public float Scale { get; set; }
    public Guid ComponentId { get; set; }
    public float VerticalSpacing { get; set; }
    public float HorizontalSpacing { get; set; }

    /// <summary>
    /// Defines the overrides applied to the instance.
    /// </summary>
    public List<Override> Overrides { get; } = new();
}