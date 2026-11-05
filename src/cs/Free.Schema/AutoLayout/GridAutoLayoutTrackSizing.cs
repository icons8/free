namespace Free.Schema;

/// <summary>
/// Defines how a grid track computes its size.
/// </summary>
public class GridAutoLayoutTrackSizing
{
    /// <summary>
    /// Track sizing mode.
    /// </summary>
    public GridAutoLayoutTrackMode Mode { get; set; }

    /// <summary>
    /// Nonnegative length for fixed sizing or weight for fractional sizing. Omission means zero for fixed sizing, one for normal fractional sizing, or zero for an explicit fractional minimum. Hug sizing ignores the value.
    /// </summary>
    public float Value { get; set; }
}
