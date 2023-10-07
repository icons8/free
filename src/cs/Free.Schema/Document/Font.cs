namespace Free.Schema.Document;

public class Font
{
    public string Data { get; set; }
    public string Name { get; set; }
    public string FileName { get; set; }
    public List<string> PostscriptNames { get; } = new();
}