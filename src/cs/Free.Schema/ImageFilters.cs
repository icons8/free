namespace Free.Schema;

public sealed class ImageFilters
{
    public bool IsEnabled { get; set; }

    public const float MinBrightness = -1;
    public const float DefaultBrightness = 0;
    public const float MaxBrightness = 1;
    public float Brightness { get; set; } = DefaultBrightness;

    public const float MinContrast = 0;
    public const float DefaultContrast = 1;
    public const float MaxContrast = 4;
    public float Contrast { get; set; } = DefaultContrast;

    public const float MinHue = -float.Pi;
    public const float DefaultHue = 0;
    public const float MaxHue = float.Pi;
    public float Hue { get; set; } = DefaultHue;

    public const float MinSaturation = 0;
    public const float DefaultSaturation = 1;
    public const float MaxSaturation = 2;
    public float Saturation { get; set; } = DefaultSaturation;
}