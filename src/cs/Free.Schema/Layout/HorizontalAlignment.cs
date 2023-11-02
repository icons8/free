namespace Free.Schema;
/// <summary>
/// Defines how a set of layers is aligned horizontally.
/// </summary>
public enum HorizontalAlignment : byte
{
    //integer serializable
    /// <summary>
    /// Layers are aligned to the left.
    /// </summary>
    Left = 0,
    /// <summary>
    /// Layers are horizontally centered.
    /// </summary>
    Center = 1,
    /// <summary>
    /// Layers are aligned to the right.
    /// </summary>
    Right = 2,
    /// <summary>
    /// Layers are horizontally justified.
    /// </summary>
    Distribute = 3
}