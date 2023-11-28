namespace Free.Schema;

/// <summary>
/// Export settings.
/// </summary>
public class ExportOption
{
    /// <summary>
    /// Defines the width/height of the exported object. Valid only when ScaleType is *Width* or *Height*.
    /// </summary>
    public float Size { get; set; } = 0;
    /// <summary>
    /// Export format. Default: PNG.
    /// </summary>
    public string Format { get; set; } = "png";
    /// <summary>
    /// User-defined suffix/preffix (string) added to the export file name. Default: empty.
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// Defines whether a suffix or preffix will be added to the export files name. Default: suffix.
    /// </summary>
    public NamingScheme Naming { get; set; } = NamingScheme.Suffix;
    /// <summary>
    /// Defines the scale used when exporting an object. Valid only when ScaleType is set to *Scale*.
    /// </summary>
    public float Scale { get; set; } = 1;
    /// <summary>
    /// Defines the scale type: Scale(px)/Width/Height. The Width and Height types are currently not supported.
    /// </summary>
    public ScaleType Type { get; set; } = ScaleType.Scale;
}