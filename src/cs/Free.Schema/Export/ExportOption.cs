namespace Free.Schema;

/// <summary>
/// Export settings.
/// </summary>
public class ExportOption
{
    /// <summary>
    /// Export format. Default: PNG.
    /// </summary>
    public string Format { get; set; } = "PNG";
    /// <summary>
    /// Defines the scale type: Scale/Width/Height. The Width and Height types are currently not supported.
    /// </summary>
    public ScaleType Type { get; set; } = ScaleType.Scale;
    /// <summary>
    /// Defines the width/height/scale of the exported object. Dependent on the type of the scale. 
    /// </summary>
    public float Size { get; set; } = 0;
    /// <summary>
    /// User-defined suffix/preffix (string) added to the export file name. Default: empty.
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// Defines whether a suffix or preffix will be added to the export files name. Default: suffix.
    /// </summary>
    public NamingScheme Naming { get; set; } = NamingScheme.Suffix;
}