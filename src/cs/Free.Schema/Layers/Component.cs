namespace Free.Schema;

/// <summary>
/// A component is a reusable groups of layers.
/// </summary>
public class Component : Frame
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "COMPONENT";
    /// <summary>
    /// Unique component identifier.
    /// </summary>
    public Guid ComponentId { get; set; }

    /// <summary>
    /// Defines whether to include background in component instances.
    /// </summary>
    [SketchCompatibility]
    public bool BackgroundInInstance { get; set; }

    /// <summary>
    /// Indicates that the component belongs to the Lunacy default component library (see the Component Tool on the Toolbar)
    /// </summary>
    public bool Predefined { get; set; }

    /// <summary>
    /// Reserved for future use. Will be used for component filters.
    /// </summary>
    public ComponentType ComponentType { get; set; }

    /// <summary>
    /// Unique Figma Component Id. Used to connect shared libraries and documents imported from figma. 
    /// </summary>
    public string FigmaId { get; set; }
}