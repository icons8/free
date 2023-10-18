namespace Free.Schema;
/// <summary>
/// shared.json
/// shared style from ui kit
/// </summary>
public class ForeignSharedStyle
{
    public Guid Id { get; set; }
    /// <summary>
    /// ui kit id
    /// </summary>
    public Guid LibraryId { get; set; }
    /// <summary>
    /// ui kit name
    /// </summary>
    public string? LibraryName { get; set; }
    /// <summary>
    /// This is sketch flag for private shared styled.
    /// </summary>
    [SketchCompatibility]
    public bool ComponentPrivate { get; set; }
    /// <summary>
    /// ID of Style in Remote Shared Library.
    /// </summary>
    public Guid RemoteID { get; set; }

    public SharedStyle Style { get; } = new();
}