namespace Free.Schema;

public class Instance : Styled
{
    public override string _t => "INSTANCE";
    
    /// <summary>
    /// Sets the corner radius of the instance frame.
    /// </summary>
    public float[] CornerRadius { get; set; } = new float[4];
    public bool SmoothCorners { get; set; }
    public ILayoutContainer? LayoutStrategy { get; set; }
    
    /// <summary>
    /// scale of component
    /// </summary>
    public float Scale { get; set; }
    public Guid ComponentId { get; set; }
    
    [SketchCompatibility]
    public float VerticalSpacing { get; set; }
    
    [SketchCompatibility]
    public float HorizontalSpacing { get; set; }

    /// <summary>
    /// Defines the overrides applied to the instance.
    /// </summary>
    public List<Override> Overrides { get; } = new();
}