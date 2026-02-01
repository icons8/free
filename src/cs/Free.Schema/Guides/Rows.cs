namespace Free.Schema;
/// <summary>
/// Defines row settings in a layout guide.
/// </summary>
public sealed class Rows : LayoutGuideBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public string _t => "ROWS";
    /// <summary>
    /// If rows are enabled.
    /// </summary>
    public bool Enabled { get; set; }
    /// <summary>
    /// Vertical alignment settings.
    /// </summary>
    public LayoutVerticalAlignment Align { get; set; }
    /// <summary>
    /// Offset value.
    /// </summary>
    public int Offset { get; set; }
    /// <summary>
    /// Number of rows.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Gutter value.
    /// </summary>
    public int Gutter { get; set; }
    /// <summary>
    /// Row width.
    /// </summary>
    public int Width { get; set; }
    /// <summary>
    /// Row color.
    /// </summary>
    public Color Color { get; set; }
}