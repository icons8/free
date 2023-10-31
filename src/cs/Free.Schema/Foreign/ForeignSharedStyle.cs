namespace Free.Schema;
/// <summary>
/// Describes styles from external libraries. 
/// </summary>
public class ForeignSharedStyle
{
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
    /// A sketch flag for private shared styles.
    /// </summary>
    [SketchCompatibility]
    public bool ComponentPrivate { get; set; }
    /// <summary>
    /// Style identifier in the external library.
    /// </summary>
    public Guid RemoteID { get; set; }
    /// <summary>
    /// Shared Style value
    /// </summary>
    public SharedStyle Style { get; } = new();
}