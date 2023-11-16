namespace Free.Schema;
/// <summary>
/// This is Frame Preset. Also used to determine viewport size for a large frame to scroll it properly.
/// </summary>

public sealed class PrototypeViewport
{
    public string? Name { get; set; }
    public Size Size { get; set; }
    public Guid LibraryId { get; set; }
    public Guid TemplateId { get; set; }
}