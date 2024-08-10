namespace Free.Schema;
/// <summary>
/// Describes color variables from external libraries.
/// </summary>
public class ForeignColorVariable
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
    /// Color variable ID in the external library.
    /// </summary>
    [SketchCompatibility]
    public Guid RemoteId { get; set; }
    /// <summary>
    /// Value of the color variable.
    /// </summary>
    public ColorVariable? Color { get; set; }
}