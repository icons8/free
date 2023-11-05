namespace Free.Schema;

/// <summary>
/// Contains metadata about the document.
/// </summary>
public class Meta
{
    /// <summary>
    /// Free Format version.
    /// </summary>
    public int Version { get; set; }
    /// <summary>
    /// App name.
    /// </summary>
    public string App { get; set; }
    /// <summary>
    /// App variant: beta/standalone/store/web/etc.
    /// </summary>
    public string Variant { get; set; }
    /// <summary>
    /// App version.
    /// </summary>
    public string AppVersion { get; set; }
    /// <summary>
    /// Email address of the user who last saved the document.
    /// </summary>
    public string? By { get; set; }
}