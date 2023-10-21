namespace Free.Schema;
/// <summary>
/// Describes color components from external libraries.
/// </summary>
public class ForeignComponent
{
    /// <summary>
    /// Unique component identifier.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Unique library identifier.
    /// </summary>
    public Guid LibraryId { get; set; }
    /// <summary>
    /// Library name.
    /// </summary>
    public string? LibraryName { get; set; }
    /// <summary>
    ///  A sketch flag for private shared components.
    /// </summary>
    [SketchCompatibility]
    public bool ComponentPrivate { get; set; }
    /// <summary>
    /// Original state of the component upon import.
    /// </summary>
    public Component? Original { get; set; }

    /// <summary>
    /// Current state of the component.
    /// </summary>
    public Component? Component { get; set; }
}