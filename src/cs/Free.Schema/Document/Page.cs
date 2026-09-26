namespace Free.Schema;

/// <summary>
/// Document page properties.
/// </summary>
public class Page
{
    /// <summary>
    /// Unique page ID.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Page name.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Whether the page name was explicitly set by the user.
    /// </summary>
    [LunacySpecific]
    public bool NameFixed { get; set; }

    /// <summary>
    /// Canvas color.
    /// </summary>
    public Color Background { get; set; }

    /// <summary>
    /// If the page is used to store components.
    /// </summary>
    public bool ComponentPage { get; set; }
    
    /// <summary>
    /// Rulers applied by the user.
    /// </summary>
    public Rulers Rulers { get; } = new();
    /// <summary>
    /// Persistent distance measurements created on the page.
    /// </summary>
    [LunacySpecific]
    public List<Measurement> Measurements { get; } = new();
    
    /// <summary>
    /// Point where the user left off the page.
    /// </summary>
    public Point Origin { get; set; }
    /// <summary>
    /// Zoom scale last applied to the page.
    /// </summary>
    public float Zoom { get; set; } = 1;
    /// <summary>
    /// List of layers in the page.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}
