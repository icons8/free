namespace Free.Schema;
/// <summary>
/// Defines the fill type.
/// </summary>
public enum FillType : byte
{
    /// <summary>
    /// Solid color fill.
    /// </summary>
    Color = 0,
    /// <summary>
    /// Gradient fill.
    /// </summary>
    Gradient = 1,
    /// <summary>
    /// Image fill.
    /// </summary>
    Pattern = 4,
}