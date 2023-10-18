namespace Free.Schema;

/// <summary>A position color pair representing a gradient stop.</summary>
public sealed class GradientStop
{
    /// <summary>Value between 0 and 1 representing position along gradient axis.</summary>
    public float Pos { get; set; }

    /// <summary>Color attached to corresponding position.</summary>
    public Color Color { get; set; } = new(255, 255, 255);
}