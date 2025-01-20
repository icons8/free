namespace Free.Schema;
/// <summary>
/// An instance is a copy of the main component. With instances, you can reuse the same design element in multiple places in your project while retaining a connection to the main component. 
/// </summary>
public class Instance : Styled
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "INSTANCE";
    
    /// <summary>
    /// Sets the corner radius of the instance frame.
    /// </summary>
    public float[] CornerRadius { get; set; } = new float[4];

    /// <summary>
    /// Enables smooth rounded corners like in iOS interfaces.
    /// </summary>
    public bool SmoothCorners { get; set; }
    
    /// <summary>
    /// Scale of the instance.
    /// </summary>
    public float Scale { get; set; }
    /// <summary>
    /// Unique component identifier.
    /// </summary>
    public Guid ComponentId { get; set; }
    
    /// <summary>
    /// Defines vertical spacing.
    /// </summary>
    [SketchCompatibility]    
    public float VerticalSpacing { get; set; }
    /// <summary>
    /// Defines horizontal spacing.
    /// </summary>
    [SketchCompatibility]
    public float HorizontalSpacing { get; set; }

    /// <summary>
    /// Defines the overrides applied to the instance.
    /// </summary>
    public List<Override> Overrides { get; } = new();
}