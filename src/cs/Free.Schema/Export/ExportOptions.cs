namespace Free.Schema;

public class ExportOptions
{
    public List<NodeExportFormat> Formats { get; set; } = new();
    public bool Trim { get; set; }
}