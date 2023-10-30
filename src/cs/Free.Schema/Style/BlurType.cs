namespace Free.Schema;
/// <summary>
/// Defines the blur type.
/// </summary>
public enum BlurType : byte
{
    /// <summary>
    /// Gaussian blur.
    /// </summary>
    Gaussian = 0,
    /// <summary>
    /// Motion blur. Currently not supported. ????
    /// </summary>
    Motion = 1,
    /// <summary>
    /// Zoom blur. Currently not supported. ???
    /// </summary>
    Zoom = 2,
    /// <summary>
    /// Background blur.
    /// </summary>
    Background = 3
}