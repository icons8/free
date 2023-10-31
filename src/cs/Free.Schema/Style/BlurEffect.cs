namespace Free.Schema;
/// <summary>
/// Defines the settings of the blur effect.
/// </summary>
public sealed class BlurEffect
{
    /// <summary>
    /// Saturation. Only for background blur.
    /// </summary>
    public float Saturation { get; set; } = 1;//max = 2
    /// <summary>
    /// Blur Radius.
    /// </summary>
    public float Radius { get; set; } = 10;
    /// <summary>
    /// If the blur is enabled.
    /// </summary>
    public bool Enabled { get; set; }
    /// <summary>
    /// Sets the blur type.
    /// </summary>
    public BlurType Type { get; set; } = BlurType.Gaussian;
    /// <summary>
    /// Center point of motion blur.
    /// </summary>
    [SketchCompatibility]
    public Point Center { get; set; } = new(0.5f, 0.5f);
    /// <summary>
    /// Angle of motion for motion blur.
    /// </summary>
    [SketchCompatibility]
    public float MotionAngle { get; set; }
}