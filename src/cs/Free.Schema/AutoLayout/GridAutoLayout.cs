namespace Free.Schema;

/// <summary>
/// Defines the two-dimensional auto layout of a frame or instance. This field is mutually exclusive with autoLayout.
/// Older readers can display the layer and its children using their stored positions and sizes.
/// </summary>
public class GridAutoLayout
{
    /// <summary>
    /// Column tracks in left-to-right order. At least one column is required.
    /// </summary>
    public List<GridAutoLayoutTrack> Columns { get; } = new();

    /// <summary>
    /// Row tracks in top-to-bottom order. A missing or empty array defines no explicit row sizing.
    /// </summary>
    public List<GridAutoLayoutTrack> Rows { get; } = new();

    /// <summary>
    /// Nonnegative space between column tracks in document units.
    /// </summary>
    public float ColumnGap { get; set; }

    /// <summary>
    /// Nonnegative space between row tracks in document units.
    /// </summary>
    public float RowGap { get; set; }

    /// <summary>
    /// Derives the row count from the in-flow children.
    /// </summary>
    public bool AutoRows { get; set; }

    /// <summary>
    /// Places in-flow children in layer order, left to right and then top to bottom. Stored anchors apply when false.
    /// </summary>
    public bool AutoPlacement { get; set; }

    /// <summary>
    /// Padding around the tracks.
    /// </summary>
    public Thickness Padding { get; set; }

    /// <summary>
    /// Uses the frame's fixed width instead of its content width or the width assigned by its parent.
    /// </summary>
    public bool FixWidth { get; set; }

    /// <summary>
    /// Uses the frame's fixed height instead of its content height or the height assigned by its parent.
    /// </summary>
    public bool FixHeight { get; set; }

    /// <summary>
    /// Includes outer stroke widths in layout measurements.
    /// </summary>
    public bool StrokesIncluded { get; set; }

    /// <summary>
    /// Draws earlier children above later children.
    /// </summary>
    public bool ReverseZIndex { get; set; }
}
