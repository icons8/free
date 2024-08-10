namespace Free.Schema;
/// <summary>
/// Describes styles from external libraries. 
/// </summary>
public class ForeignSharedStyle
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
    /// Style identifier in the external library.
    /// </summary>
    public Guid RemoteID { get; set; }
    /// <summary>
    /// Shared style name.
    /// </summary>
    public SharedStyle Style { get; } = new();
}