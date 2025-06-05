namespace Free.Schema;

/// <summary>
/// Base class for a shared style
/// </summary>
public abstract class StyleBase
{
    /// <summary>
    /// Unique style ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Style name.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Style version.
    /// </summary>
    public int Version { get; set; }
    
    /// <summary>
    /// Unique Figma Style Id. Used to connect shared libraries and documents imported from figma. 
    /// </summary>
    public string FigmaId { get; set; }
}