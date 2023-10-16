namespace Free.Schema;

public class ExportOptions
{
    public List<ExportFormat> Formats { get; set; } = new();
    [SketchCompatibility]
    public bool Trim { get; set; }
}