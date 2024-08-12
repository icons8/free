namespace Free.Schema;
/// <summary>
/// Defines the advanced options of borders, arrows, lines, and paths drawn with the Pen or Pencil tools.
/// </summary>
public sealed class BorderOptions
{
    /// <summary>
    /// Defines the shape of line caps.
    /// </summary>
    public LineCap LineCap { get; set; } = LineCap.Butt;
    /// <summary>
    /// Defines the appearance of line folds.
    /// </summary>
    public LineJoin LineJoin { get; set; } = LineJoin.Miter;
    /// <summary>
    /// Defines the size of dashes.
    /// </summary>
    public float[] Dash { get; set; }
}