namespace Free.Schema;

/// <summary>
/// Style saved in the document.
/// </summary>
public class SharedStyle
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
    /// Layer style settings.
    /// </summary>
    public Style Style { get; }
    /// <summary>
    /// Text style settings.
    /// </summary>
    public TextStyle? TextStyle { get; set; }
}