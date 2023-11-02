namespace Free.Schema;

/// <summary>
/// Defines the shape of the end caps of open paths drawn with the Line, Arrow, or Pen/Pencil tools.
/// </summary>
public enum LineCap : byte
{
    /// <summary>
    /// No cap (default).
    /// </summary>
    Butt = 0,
    /// <summary>
    /// Adds a rounded end to a path that extends past the vector point.
    /// </summary>
    Round = 1,
    /// <summary>
    /// Similar to the rounded cap, but with straight edges.
    /// </summary>
    Square = 2,
}