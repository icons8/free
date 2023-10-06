namespace Free.Schema;

public sealed class PrototypeViewport
{
    public string? Name { get; set; }
    public Size Size { get; set; }
    public Guid LibraryId { get; set; }
    public Guid TemplateId { get; set; }
}