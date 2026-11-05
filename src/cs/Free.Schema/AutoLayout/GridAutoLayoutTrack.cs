namespace Free.Schema;

/// <summary>
/// Defines the normal sizing function and optional distinct minimum sizing function of a grid track.
/// </summary>
public class GridAutoLayoutTrack : GridAutoLayoutTrackSizing
{
    /// <summary>
    /// Explicit minimum sizing function. If omitted, the track uses the minimum implied by its mode.
    /// </summary>
    public GridAutoLayoutTrackSizing? Minimum { get; set; }
}
