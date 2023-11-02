namespace Free.Schema;
/// <summary>
/// Defines the appearance of the corners for arrows and paths with corners drawn with the Pen/Pencil tool.
/// </summary>
public enum LineJoin : byte
{
    /// <summary>
    /// Square.
    /// </summary>
    Miter = 0,//Square
    /// <summary>
    /// Rounded.
    /// </summary>
    Round = 1,
    /// <summary>
    /// Bevelled.
    /// </summary>
    Bevel = 2
}