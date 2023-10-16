namespace Free.Schema.Document;

/// <summary>
/// Shared fonts are stored in the document 
/// </summary>
public class Font
{
    public string Data { get; set; }
    public string Name { get; set; }
    public string FileName { get; set; }
    public List<string> PostscriptNames { get; } = new();
}