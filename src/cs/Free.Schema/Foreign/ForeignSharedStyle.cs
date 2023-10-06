namespace Free.Schema.Document;

public class ForeignSharedStyle
{
    public Guid Id { get; set; }
    public Guid LibraryId { get; set; }

    public string? SourceLibraryName { get; set; }

    public bool ComponentPrivate { get; set; }

    public Guid RemoteID { get; set; }

    public SharedStyle? Style { get; set; }
}