namespace Free.Schema;

public class ExportOptions
{
    public List<ExportFormat> Formats { get; set; } = new();
    
    /// <summary>
    /// trim empty pixels for exported image
    /// </summary>
    public bool Trim { get; set; }
}