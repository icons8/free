namespace Free.Schema;

/// <summary>
/// Prototyping scroll overflow of a layer.
/// </summary>
public enum FlowScrollOverflow : byte
{
    NoScrolling = 0,
    Horizontal = 1,
    Vertical = 2,
    Both = 3,
    /// <summary>
    /// Mixed overflow state used when combined selections differ.
    /// </summary>
    Mixed = 255,
}
