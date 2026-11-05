namespace Free.Schema;

/// <summary>
/// Specifies how a grid track is sized along its axis.
/// </summary>
public enum GridAutoLayoutTrackMode
{
    /// <summary>
    /// Uses a fixed length in document units.
    /// </summary>
    Fixed = 0,

    /// <summary>
    /// Sizes the track around its contents.
    /// </summary>
    Hug = 1,

    /// <summary>
    /// Receives a weighted share of the remaining space.
    /// </summary>
    Fraction = 2
}
