namespace Free.Schema;

/// <summary>
/// Prototyping action animation.
/// </summary>
public class FlowAnimation
{
    /// <summary>
    /// If animation is enabled.
    /// </summary>
    public bool Enabled { get; set; }
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
    public int Duration { get; set; }
    /// <summary>
    /// Animation curve float point array.
    /// </summary>
    public float[] Curve { get; set; }
}