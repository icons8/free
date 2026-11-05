namespace Free.Schema;

/// <summary>
/// Places and aligns a direct child of a grid auto layout frame. Hidden and absolutely positioned children do not occupy cells.
/// </summary>
public class GridAutoLayoutItem
{
    /// <summary>
    /// Zero-based manual row anchor. An omitted value or -1 leaves the row anchor unset.
    /// </summary>
    public int Row { get; set; } = -1;

    /// <summary>
    /// Zero-based manual column anchor. An omitted value or -1 leaves the column anchor unset.
    /// </summary>
    public int Column { get; set; } = -1;

    /// <summary>
    /// Positive number of rows occupied by the child, including its anchor row.
    /// </summary>
    public int RowSpan { get; set; } = 1;

    /// <summary>
    /// Positive number of columns occupied by the child, including its anchor column.
    /// </summary>
    public int ColumnSpan { get; set; } = 1;

    /// <summary>
    /// Horizontal alignment inside the occupied cells.
    /// </summary>
    public GridAutoLayoutAlignment Horizontal { get; set; }

    /// <summary>
    /// Vertical alignment inside the occupied cells.
    /// </summary>
    public GridAutoLayoutAlignment Vertical { get; set; }
}
