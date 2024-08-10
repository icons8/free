namespace Free.Schema;
/// <summary>
/// Describes color components from external libraries.
/// </summary>
public class ForeignComponent
{
    /// <summary>
    /// URL to the Server of Library
    /// </summary>
    public string? Server { get; set; }
    /// <summary>
    /// Unique library identifier.
    /// </summary>
    public Guid LibraryId { get; set; }
    /// <summary>
    /// Library name.
    /// </summary>
    public string? LibraryName { get; set; }
    /// <summary>
    /// Original state of the component upon import.
    /// </summary>
    public Component? Original { get; set; }

    /// <summary>
    /// Current state of the component.
    /// </summary>
    public Component? Component { get; set; }
}