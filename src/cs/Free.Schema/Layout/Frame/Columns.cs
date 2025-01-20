namespace Free.Schema;
/// <summary>
/// Defines column settings in a layout grid.
/// </summary>
public class Columns : GridLayoutBase
{
    public string _t => "COLS";
    /// <summary>
    /// If columnns are enabled.
    /// </summary>
    public bool Enabled { get; set; }
    /// <summary>
    /// Horizontal alignment settings.
    /// </summary>
    public LayoutHorizontalAlignment Align { get; set; }
    /// <summary>
    /// Offset value.
    /// </summary>
    public int Offset { get; set; }
    /// <summary>
    /// Number of columns.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Gutter value.
    /// </summary>
    public int Gutter { get; set; }
    /// <summary>
    /// Column width.
    /// </summary>
    public int Width { get; set; }
    /// <summary>
    /// Column color.
    /// </summary>
    public Color Color { get; set; }
}