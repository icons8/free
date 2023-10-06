namespace Free.Schema;

/// <summary>An object that represent a Gradient.</summary>
public sealed class Gradient
{
    /// <summary>The type of the Gradient.</summary>
    public GradientType Type { get; set; } = GradientType.Linear;

    /// <summary>The position of the start of the Gradient.</summary>
    public Point From { get; set; } = new(0.5f, 0);

    /// <summary>The position of the end of the Gradient.</summary>
    public Point To { get; set; } = new(0.5f, 1);
    
    /// <summary>The position of the side point of the Gradient. Used for Radial and Angular Gragients</summary>
    public Point Side { get; set; }

    /// <summary>The different stops of the Gradient.</summary>
    public List<GradientStop> Stops { get; } = new List<GradientStop>();
}