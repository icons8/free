namespace Free.Schema;

/// <summary>
/// Prototyping scroll behavior of a layer.
/// </summary>
public enum FlowScrollBehavior : byte
{
    /// <summary>
    /// Regular behavior of a layer.
    /// </summary>
    Scroll = 0,
    /// <summary>
    /// Fixed position on scroll.
    /// </summary>
    Fixed = 1,
    /// <summary>
    /// Stick to the edge on scroll.
    /// </summary>
    Sticky = 2,
}