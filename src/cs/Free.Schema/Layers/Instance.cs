namespace Free.Schema;
/// <summary>
/// An instance is a copy of the main component. With instances, you can reuse the same design element in multiple places in your project while retaining a connection to the main component. 
/// </summary>
public class Instance : Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "INSTANCE";
    
    /// <summary>
    /// Scale of the instance.
    /// </summary>
    public float Scale { get; set; }
    /// <summary>
    /// Unique component identifier.
    /// </summary>
    public Guid ComponentId { get; set; }

    /// <summary>
    /// Auto Layout Properties
    /// </summary>
    public AutoLayoutContainer Container { get; set; }
    
    /// <summary>
    /// Defines the overrides applied to the instance.
    /// </summary>
    public List<Override> Overrides { get; } = new();
}