namespace Free.Schema;

/// <summary>
/// Contains metadata about the document
/// </summary>
public class Meta
{
    /// <summary>
    /// Free Format Version
    /// </summary>
    public int Version { get; set; }
    /// <summary>
    /// App Name
    /// </summary>
    public string App { get; set; }
    /// <summary>
    /// App Variant - (beta/standalone/store/web/etc.)
    /// </summary>
    public string Variant { get; set; }
    /// <summary>
    /// App Version
    /// </summary>
    public string AppVersion { get; set; }
    /// <summary>
    /// Saved by who ? email address
    /// </summary>
    public string? By { get; set; }
}