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
    /// Straight point.
    /// </summary>
    Straight = 1,
    /// <summary>
    /// Mirrored branches.
    /// </summary>
    Mirrored = 2,
    /// <summary>
    /// Asymmetric branches.
    /// </summary>
    Asymmetric = 3,
    /// <summary>
    /// Disconnected branches.
    /// </summary>
    Disconnected = 4,
    /// <summary>
    /// Only From branch.
    /// </summary>
    OnlyFrom = 4,
    /// <summary>
    /// Only To branch.
    /// </summary>
    OnlyTo = 5,
}