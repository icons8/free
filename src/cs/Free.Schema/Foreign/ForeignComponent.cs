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
    public string? LibraryName { get; set; }
    /// <summary>
    ///  This is sketch flag for private shared components.
    /// </summary>
    [SketchCompatibility]
    public bool ComponentPrivate { get; set; }
    /// <summary>
    /// Original state of component on import
    /// </summary>
    public Component? Original { get; set; }

    /// <summary>
    /// Current state of component
    /// </summary>
    public Component? Component { get; set; }
}