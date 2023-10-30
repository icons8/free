namespace Free.Schema;
/// <summary>
/// Defines the types of points on Bézier curves.
/// </summary>
public enum CurveMode : byte
{
    /// <summary>
    /// undefined.
    /// </summary>
    None = 0,
    /// <summary>
    /// Straight.
    /// </summary>
    Straight = 1,
    /// <summary>
    /// Mirrored.
    /// </summary>
    Mirrored = 2,
    /// <summary>
    /// Asymmetric.
    /// </summary>
    Asymmetric = 3,
    /// <summary>
    /// Disconnected.
    /// </summary>
    Disconnected = 4,
}