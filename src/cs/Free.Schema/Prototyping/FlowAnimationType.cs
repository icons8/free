namespace Free.Schema;

/// <summary>
/// Prototyping action animation type.
/// </summary>
public enum FlowAnimationType : byte
{
    Instant = 0,
    Dissolve = 1,
    SmartAnimate = 2,
    MoveIn = 3,
    MoveOut = 4,
    Push = 5,
    SlideIn = 6,
    SlideOut = 7,
    Scroll = 8,
    /// <summary>
    /// Animates matching layers between source and target frames.
    /// </summary>
    MagicMove = 9,
}
