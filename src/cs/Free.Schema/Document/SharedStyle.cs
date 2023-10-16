namespace Free.Schema.Document;

/// <summary>
/// style saved in the document
/// </summary>
public class SharedStyle
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    /// <summary>
    /// Layer style settings
    /// </summary>
    public Style Style { get; }
    /// <summary>
    /// If this is a text style, text settings will be available
    /// </summary>
    public TextStyle? TextStyle { get; set; }
}