namespace Free.Schema;
/// <summary>
/// This is a frame preset. Also used to determine viewport size for a large frame to scroll it properly.
/// </summary>

public sealed class PrototypeViewport
{
    /// <summary>
    /// Unique frame identifier.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Frame name.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Frame size.
    /// </summary>
    public Size Size { get; set; }
    /// <summary>
    /// Library identifier.
    /// </summary>
    public Guid LibraryId { get; set; }
}