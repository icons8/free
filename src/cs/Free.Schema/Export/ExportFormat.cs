namespace Free.Schema;

/// <summary>
/// export setting
/// </summary>
public class ExportFormat
{
    /// <summary>
    /// todo
    /// </summary>
    public float Size { get; set; }
    /// <summary>
    /// export format, default is png
    /// </summary>
    public string Format { get; set; } = "png";
    /// <summary>
    /// suffix/preffix (text), default is empty
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// is suffix or preffix, default is suffix
    /// </summary>
    public NamingScheme Naming { get; set; } = NamingScheme.Suffix;
    /// <summary>
    /// scale with which the object is imported
    /// </summary>
    public float Scale { get; set; }
    /// <summary>
    /// scale(px)/width/height, default is scale, right now we're only supporting the scale
    /// </summary>
    public ScaleType Type { get; set; } = ScaleType.Scale;
}