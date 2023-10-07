namespace Free.Schema.Document;

public class ForeignComponent
{
    public Guid Id { get; set; }
    
    public Guid LibraryId { get; set; }

    public string? SourceLibraryName { get; set; }

    public bool ComponentPrivate { get; set; }

    public Component? Original { get; set; }

    public Component? Component { get; set; }
}