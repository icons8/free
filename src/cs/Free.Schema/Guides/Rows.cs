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
    public bool Enabled { get; set; } = true;
    /// <summary>
    /// Vertical alignment settings.
    /// </summary>
    public LayoutVerticalAlignment Align { get; set; }
    /// <summary>
    /// Offset value.
    /// </summary>
    public int Offset { get; set; }
    /// <summary>
    /// Float Variable Id of an Offset value.
    /// </summary>
    public Guid OffsetId { get; set; }
    /// <summary>
    /// Number of rows.
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
    /// Row height.
    /// </summary>
    public int Height { get; set; }
    /// <summary>
    /// Float Variable Id of a Height value.
    /// </summary>
    public Guid HeightId { get; set; }
    /// <summary>
    /// Row color.
    /// </summary>
    public Color Color { get; set; } = new(0x19FF0000);
}
