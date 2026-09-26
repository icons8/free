namespace Free.Schema;
/// <summary>
/// Defines text weight overrides for components.
/// </summary>

[SketchCompatibility]
public sealed class TextWeightOverride
{
    /// <summary>
    /// Font slant value.
    /// </summary>
    public float Slant { get; set; }
    /// <summary>
    /// Font proportion value.
    /// </summary>
    public float Proportion { get; set; }
    /// <summary>
    /// Font symbolic traits value.
    /// </summary>
    public float Symbolic { get; set; }
    /// <summary>
    /// Font weight value.
    /// </summary>
    public float Weight { get; set; }
    /// <summary>
    /// PostScript font name.
    /// </summary>
    public string? PostScriptName { get; set; }
}
