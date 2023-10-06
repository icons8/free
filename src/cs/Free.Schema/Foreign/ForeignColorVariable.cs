namespace Free.Schema.Document;

public class ForeignColorVariable
{
    public Guid Id { get; set; }
    public Guid LibraryId { get; set; }

    public string? SourceLibraryName { get; set; }
    public bool ComponentPrivate { get; set; }

    public Guid RemoteId { get; set; }

    public ColorVariable? LocalColor { get; set; }
}