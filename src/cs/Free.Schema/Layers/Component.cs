namespace Free.Schema;

/// <summary>
/// Components are reusable groups of layers.
/// </summary>
public class Component : Frame
{
    public override string _t => "COMPONENT";
    public Guid ComponentId { get; set; }

    /// <summary>
    /// Include background in component instances.
    /// </summary>
    [SketchCompatibility]
    public bool BackgroundInInstance { get; set; }

    /// <summary>
    /// ???????????????
    /// </summary>
    public bool Predefined { get; set; }

    /// <summary>
    /// Reserved for future use.
    /// </summary>
    public string ComponentType { get; set; }
}