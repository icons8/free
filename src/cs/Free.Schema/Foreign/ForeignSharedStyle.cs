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
    public string? SourceLibraryName { get; set; }
    /// <summary>
    /// todo
    /// </summary>
    public bool ComponentPrivate { get; set; }
    /// <summary>
    /// todo
    /// </summary>
    public Guid RemoteID { get; set; }

    public SharedStyle Style { get; } = new();
}