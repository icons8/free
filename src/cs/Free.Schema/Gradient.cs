namespace Free.Schema;

/// <summary>An object that represent a Gradient.</summary>
public sealed class Gradient
{
    /// <summary>The type of the Gradient.</summary>
    public GradientType GradientType { get; set; } = GradientType.Linear;

    /// <summary>The position of the start of the Gradient.</summary>
    public Point From { get; set; } = new(0.5f, 0);

    /// <summary>The position of the end of the Gradient.</summary>
    public Point To { get; set; } = new(0.5f, 1);

    /// <summary>The different stops of the Gradient.</summary>
    public List<GradientStop> Stops { get; } = new List<GradientStop>();

    /// <summary>When the gradient is <see cref="Schema.GradientType.Radial"/>, the from and to points
    /// makes one axis of the ellipse of the gradient while the aspect ratio determine the length of the orthogonal axis
    /// (aspectRatio == 1 means that it’s a circle).</summary>
    public float AspectRatio { get; set; }
}