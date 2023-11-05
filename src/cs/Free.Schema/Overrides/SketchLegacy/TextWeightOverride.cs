namespace Free.Schema;
/// <summary>
/// Defines text weight overrides.
/// </summary>

[SketchCompatibility]
public sealed class TextWeightOverride
{
    public float Slant { get; set; }
    public float Proportion { get; set; }
    public float Symbolic { get; set; }
    public float Weight { get; set; }
}