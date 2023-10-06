namespace Free.Schema;

public class ExportOptions
{
    public List<NodeExportFormat> ExportFormats { get; set; } = new();
    public List<string> IncludedLayerIds { get; set; } = new();
    public int LayerOptions { get; set; }
    public bool Trim { get; set; }
}