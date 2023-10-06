namespace Free.Schema;

public sealed class BlurEffect
{
    public const float RenderMultiply = 1.5f;
    public const float DefaultRadius = 10;
    public const float MinSaturation = 0;
    public const float DefaultSaturation = 1;
    public const float MaxSaturation = 2;

    public float Saturation { get; set; } = DefaultSaturation;
    public float Radius { get; set; } = DefaultRadius;
    public bool IsEnabled { get; set; }
    public BlurType Type { get; set; } = BlurType.Gaussian;
    public Point Center { get; set; } = new(0.5f, 0.5f);
    public float MotionAngle { get; set; }
    public bool IsExpanded { get; set; }
}