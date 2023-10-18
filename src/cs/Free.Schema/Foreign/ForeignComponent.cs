namespace Free.Schema;
/// <summary>
/// shared.json
/// component from ui kit
/// </summary>
public class ForeignComponent
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
    public Component? Original { get; set; }

    public Component? Component { get; set; }
}