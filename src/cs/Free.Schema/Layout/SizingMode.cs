namespace Free.Schema;
/// <summary>
/// Defines the behavior of auto layout containers as their content is changed.
/// </summary>
public enum SizingMode : byte
{
    //integer serializable
    /// <summary>
    /// The container adjusts to the size of the content (hug).
    /// </summary>
    Auto = 0,
    /// <summary>
    /// The container has a fixed size (fix).
    /// </summary>
    Fixed = 1
}