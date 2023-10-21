namespace Free.Schema;

/// <summary>
/// Export options.
/// </summary>
public class ExportOptions
{
    /// <summary>
    /// List of export formats set by the user.
    /// </summary>
    public List<ExportFormat> Formats { get; set; } = new();
    
    /// <summary>
    /// When enabled, trims empty pixels in exported images.
    /// </summary>
    public bool Trim { get; set; }
}