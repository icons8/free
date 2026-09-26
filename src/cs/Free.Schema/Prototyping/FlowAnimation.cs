namespace Free.Schema;

/// <summary>
/// Prototyping action animation.
/// </summary>
public struct FlowAnimation
{
    /// <summary>
    /// Creates an instant animation with the default 300 ms duration.
    /// </summary>
    public FlowAnimation()
    {
    }

    /// <summary>
    /// Animation type.
    /// </summary>
    public FlowAnimationType Type { get; set; }
    /// <summary>
    /// Animation effect.
    /// </summary>
    public FlowAnimationEffect Effect { get; set; }
    /// <summary>
    /// Animation direction.
    /// </summary>
    public FlowAnimationDirection Direction { get; set; }
    /// <summary>
    /// Animation duration in ms.
    /// </summary>
    public int Duration { get; set; } = 300;
    /// <summary>
    /// Animation curve point array. Array length is always 2. Point values are between 0 and 1.
    /// </summary>
    public Point[] Curve { get; set; }
    /// <summary>
    /// Spring animation parameters.
    /// </summary>
    public Spring? Spring { get; set; }
}
