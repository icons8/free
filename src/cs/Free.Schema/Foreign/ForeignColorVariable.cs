namespace Free.Schema;
/// <summary>
/// Describes color variables from external libraries.
/// </summary>
public class ForeignColorVariable
{
    /// <summary>
    /// Unique variable identifier.
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
    ///  A Sketch flag for private shared color variables.
    /// </summary>
    [SketchCompatibility]
    public bool ComponentPrivate { get; set; }
    /// <summary>
    /// Color variable ID in the external library.
    /// </summary>
    [SketchCompatibility]
    public Guid RemoteId { get; set; }
    /// <summary>
    /// Value of the color variable.
    /// </summary>
    public ColorVariable? Color { get; set; }
}