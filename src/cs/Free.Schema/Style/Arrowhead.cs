namespace Free.Schema;
/// <summary>
/// Defines the appearance of arrowheads.
/// </summary>
public enum Arrowhead : byte
{
    /// <summary>
    /// No arrowheads.
    /// </summary>
    None = 0,
    /// <summary>
    /// Angle.
    /// </summary>
    Arrow = 1,
    /// <summary>
    /// Triangle.
    /// </summary>
    ArrowFilled = 2,
    /// <summary>
    /// ????? What's the difference from None???
    /// </summary>
    Line = 3,
    /// <summary>
    /// Cirlce arrowhead.
    /// </summary>
    Circle = 4,
    /// <summary>
    /// Filled circle arrowhead.
    /// </summary>
    CircleFilled = 5,
    /// <summary>
    /// Square arrowhead.
    /// </summary>
    Square = 6,
    /// <summary>
    /// Filled square arrowhead.
    /// </summary>
    SquareFilled = 7,
}