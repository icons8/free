namespace Free.Schema;
/// <summary>
/// Defines the types of points on Bézier curves.
/// </summary>
public enum CurveMode : byte
{
    /// <summary>
    /// Straight point.
    /// </summary>
    Straight = 0,
    /// <summary>
    /// Mirrored branches.
    /// </summary>
    Mirrored = 1,
    /// <summary>
    /// Asymmetric branches.
    /// </summary>
    Asymmetric = 2,
    /// <summary>
    /// Disconnected branches.
    /// </summary>
    Disconnected = 3,
    /// <summary>
    /// Only From branch.
    /// </summary>
    OnlyFrom = 4,
    /// <summary>
    /// Only To branch.
    /// </summary>
    OnlyTo = 5,
}
