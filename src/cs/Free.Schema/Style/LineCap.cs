namespace Free.Schema;

/// <summary>
/// Enumeration of the positions of a border.
/// </summary>
public enum LineCap : byte
{
    /// <summary>
    /// This is the default option that’ll draw the border right to the vector point.
    /// </summary>
    Butt = 0,
    /// <summary>
    /// Creates a rounded, semi-circular end to a path that extends past the vector point.
    /// </summary>
    Round = 1,
    /// <summary>
    /// Similar to the rounded cap, but with a straight edges.
    /// </summary>
    Square = 2,
}