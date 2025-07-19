namespace Free.Schema;

/// <summary>
/// Theme Selection of a layer and it's children for a specific theme.
/// </summary>
public class ThemeSelection
{
    /// <summary>
    /// Unique identifier of the collection.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Unique identifier of the theme.
    /// </summary>
    public Guid ThemeId { get; set; }
}