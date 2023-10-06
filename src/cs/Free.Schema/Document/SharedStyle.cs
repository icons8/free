namespace Free.Schema.Document;

public class SharedStyle
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Style Style { get; }
    public TextStyle? TextStyle { get; set; }
}