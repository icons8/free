namespace Free.Schema;
/// <summary>
/// Defines the settings of the blur effect.
/// </summary>
public sealed class BlurEffect
{
    /// <summary>
    /// ????
    /// </summary>
    public const float RenderMultiply = 1.5f;
    /// <summary>
    /// ????
    /// </summary>
    public const float DefaultRadius = 10;
    /// <summary>
    /// ????
    /// </summary>
    public const float MinSaturation = 0;
    /// <summary>
    /// ????
    /// </summary>
    public const float DefaultSaturation = 1;
    /// <summary>
    /// ????
    /// </summary>
    public const float MaxSaturation = 2;
    /// <summary>
    /// ????
    /// </summary>

    public float Saturation { get; set; } = DefaultSaturation;
    /// <summary>
    /// ????
    /// </summary>
    public float Radius { get; set; } = DefaultRadius;
    /// <summary>
    /// If the blur is enabled.
    /// </summary>
    public bool Enabled { get; set; }
    /// <summary>
    /// Sets the blur type. ????
    /// </summary>
    public BlurType Type { get; set; } = BlurType.Gaussian;
    /// <summary>
    /// ????
    /// </summary>
    public Point Center { get; set; } = new(0.5f, 0.5f);
    /// <summary>
    /// ????
    /// </summary>
    public float MotionAngle { get; set; }
}