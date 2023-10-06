namespace Free.Schema.Document;

public class ForeignComponent
{
    public Guid Id { get; set; }
    
    public Guid LibraryId { get; set; }

    public string? SourceLibraryName { get; set; }

    public bool ComponentPrivate { get; set; }

    public ComponentLayer? OriginalComponent { get; set; }

    public ComponentLayer? Component { get; set; }
}