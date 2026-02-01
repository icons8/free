namespace Free.Schema;
/// <summary>
/// Defines how a set of layers is aligned vertically.
/// </summary>
public enum VerticalAlignment : byte
{
    //integer serializable
    /// <summary>
    /// Layers are aligned to the top.
    /// </summary>
    Top = 0,
    /// <summary>
    /// Layers are vertically centered.
    /// </summary>
    Center = 1,
    /// <summary>
    /// Layers are aligend to the bottom.
    /// </summary>
    Bottom = 2,
    /// <summary>
    /// Layers are vertically justified.
    /// </summary>
    Distribute = 3
}