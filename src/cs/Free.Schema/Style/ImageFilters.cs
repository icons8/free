namespace Free.Schema;
/// <summary>
/// Defines filters that can be applied to images.
/// </summary>
public sealed class ImageFilters
{
    /// <summary>
    /// If a filter is applied to the image layer.
    /// </summary>
    public bool Enabled { get; set; }

    // public const float MinBrightness = -1;
    // public const float DefaultBrightness = 0;
    // public const float MaxBrightness = 1;

    /// <summary>
    /// Brightness filter.
    /// </summary>
    public float Brightness { get; set; } = 0;

    // public const float MinContrast = 0;
    // public const float DefaultContrast = 1;
    // public const float MaxContrast = 4;
    /// <summary>
    /// Contrast filter.
    /// </summary>
    public float Contrast { get; set; } = 1;

    // public const float MinHue = -float.Pi;
    // public const float DefaultHue = 0;
    // public const float MaxHue = float.Pi;
    /// <summary>
    /// Hue filter.
    /// </summary>
    public float Hue { get; set; } = 0;

    // public const float MinSaturation = 0;
    // public const float DefaultSaturation = 1;
    // public const float MaxSaturation = 2;
    /// <summary>
    /// Saturation filter.
    /// </summary>
    public float Saturation { get; set; } = 1;
}