namespace Free.Schema;

/// <summary>
/// Type of a mask.
/// </summary>
public enum MaskType
{
    /// <summary>
    /// This mode indicated that every pixel inside the layer's fill regions will be fully visible in the masked result.
    /// </summary>
    Vector = 0,
    /// <summary>
    /// This mode indicates that the mask layer image's transparency (alpha channel) values should be used as the mask values. This is how masks work in Figma.
    /// </summary>
    Alpha = 1,
    /// <summary>
    /// This mode indicates that the luminance values of the mask layer image should be used as the mask values. This is how masks work in SVG.
    /// </summary>
    Luminance = 2,
}
