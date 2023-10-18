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
    public string? LibraryName { get; set; }
    /// <summary>
    ///  This is sketch flag for private shared color variables.
    /// </summary>
    [SketchCompatibility]
    public bool ComponentPrivate { get; set; }
    /// <summary>
    /// Id of color variable in shared library
    /// </summary>
    [SketchCompatibility]
    public Guid RemoteId { get; set; }

    public ColorVariable? Color { get; set; }
}