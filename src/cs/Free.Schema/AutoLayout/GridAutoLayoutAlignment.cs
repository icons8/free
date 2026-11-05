namespace Free.Schema;

/// <summary>
/// Specifies how a grid child is positioned within its occupied cells along one axis.
/// </summary>
public enum GridAutoLayoutAlignment
{
    /// <summary>
    /// Uses the grid's default alignment.
    /// </summary>
    Auto = 0,

    /// <summary>
    /// Aligns to the left or top edge.
    /// </summary>
    Start = 1,

    /// <summary>
    /// Centers inside the occupied cells.
    /// </summary>
    Center = 2,

    /// <summary>
    /// Aligns to the right or bottom edge.
    /// </summary>
    End = 3
}
