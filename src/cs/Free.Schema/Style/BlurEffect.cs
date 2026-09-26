namespace Free.Schema;
/// <summary>
/// Defines the settings of a blur or glass effect. Glass uses its own frost radius; Radius applies to other blur types.
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
    /// Float Variable Id of a Radius value.
    /// </summary>
    public Guid RadiusId { get; set; }
    /// <summary>
    /// Motion Angle
    /// </summary>
    public float Angle { get; set; }
    /// <summary>
    /// Direction of the light in degrees. Used by glass.
    /// </summary>
    public float GlassLightAngle { get; set; } = -45;
    /// <summary>
    /// Intensity of the light in percent (0 to 100). Used by glass.
    /// </summary>
    public float GlassLightIntensity { get; set; } = 80;
    /// <summary>
    /// Intensity of optical distortion in percent (0 to 100). Used by glass.
    /// </summary>
    public float GlassRefraction { get; set; } = 80;
    /// <summary>
    /// Depth of the curved glass edge in document units (1 to 1024).
    /// </summary>
    public float GlassDepth { get; set; } = 20;
    /// <summary>
    /// Intensity of color separation in percent (0 to 100). Used by glass.
    /// </summary>
    public float GlassDispersion { get; set; } = 50;
    /// <summary>
    /// Background blur radius in document units (0 to 1024). Used by glass.
    /// </summary>
    public float GlassFrost { get; set; } = 4;
    /// <summary>
    /// Spread of the glass lighting in percent (0 to 100).
    /// </summary>
    public float GlassSplay { get; set; } = 0;
    /// <summary>
    /// Float variable identifier for GlassLightAngle. Numeric values provide fallbacks; percentage variables use 0 to 100.
    /// </summary>
    public Guid GlassLightAngleId { get; set; }
    /// <summary>
    /// Float variable identifier for GlassLightIntensity. Numeric values provide fallbacks; percentage variables use 0 to 100.
    /// </summary>
    public Guid GlassLightIntensityId { get; set; }
    /// <summary>
    /// Float variable identifier for GlassRefraction. Numeric values provide fallbacks; percentage variables use 0 to 100.
    /// </summary>
    public Guid GlassRefractionId { get; set; }
    /// <summary>
    /// Float variable identifier for GlassDepth. Numeric values provide fallbacks; percentage variables use 0 to 100.
    /// </summary>
    public Guid GlassDepthId { get; set; }
    /// <summary>
    /// Float variable identifier for GlassDispersion. Numeric values provide fallbacks; percentage variables use 0 to 100.
    /// </summary>
    public Guid GlassDispersionId { get; set; }
    /// <summary>
    /// Float variable identifier for GlassFrost. Numeric values provide fallbacks; percentage variables use 0 to 100.
    /// </summary>
    public Guid GlassFrostId { get; set; }
    /// <summary>
    /// Float variable identifier for GlassSplay. Numeric values provide fallbacks; percentage variables use 0 to 100.
    /// </summary>
    public Guid GlassSplayId { get; set; }
    /// <summary>
    /// Zoom Blur Center
    /// </summary>
    public Point Center { get; set; } = new Point(0.5f, 0.5f);
    /// <summary>
    /// If the blur is enabled.
    /// </summary>
    public bool Enabled { get; set; } = true;
    /// <summary>
    /// Sets the blur type.
    /// </summary>
    public BlurType Type { get; set; } = BlurType.Gaussian;
}