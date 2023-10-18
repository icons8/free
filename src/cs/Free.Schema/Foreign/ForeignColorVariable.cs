namespace Free.Schema;
/// <summary>
/// shared.json
/// color variable from ui kit
/// </summary>
public class ForeignColorVariable
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
    public Guid RemoteId { get; set; }

    public ColorVariable? LocalColor { get; set; }
}