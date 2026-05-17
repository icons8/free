namespace Free.Schema;
/// <summary>
/// Defines column settings in a layout guide.
/// </summary>
public sealed class Columns : LayoutGuideBase
{
    /// <summary>
    /// Object type.
    /// </summary>
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
    /// Float Variable Id of an Offset value.
    /// </summary>
    public Guid OffsetId { get; set; }
    /// <summary>
    /// Number of columns.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// Float Variable Id of a Count value.
    /// </summary>
    public Guid CountId { get; set; }
    /// <summary>
    /// Gutter value.
    /// </summary>
    public int Gutter { get; set; }
    /// <summary>
    /// Float Variable Id of a Gutter value.
    /// </summary>
    public Guid GutterId { get; set; }
    /// <summary>
    /// Column width.
    /// </summary>
    public int Width { get; set; }
    /// <summary>
    /// Float Variable Id of a Width value.
    /// </summary>
    public Guid WidthId { get; set; }
    /// <summary>
    /// Column color.
    /// </summary>
    public Color Color { get; set; }
}