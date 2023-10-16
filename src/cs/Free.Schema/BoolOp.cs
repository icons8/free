namespace Free.Schema;

/// <summary>
/// The type of operation used to combine the children of this node.
/// </summary>
public enum BoolOp : sbyte
{
    /// <summary>
    /// Not set. Works like Difference or like Union depends on context
    /// </summary>
    None = -1,
    /// <summary>
    /// Combine
    /// </summary>
    Union = 0,
    /// <summary>
    /// Subtract one from another
    /// </summary>
    Subtract = 1,
    /// <summary>
    /// Get shapes intersection
    /// </summary>
    Intersect = 2,
    /// <summary>
    /// Draw shapes difference
    /// </summary>
    Difference = 3,
}