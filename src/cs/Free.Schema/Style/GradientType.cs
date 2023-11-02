namespace Free.Schema;

/// <summary>
/// List of Gradient types.
/// </summary>
public enum GradientType : byte
{
    /// <summary>
    /// Linear gradient: two colors appear at opposite points of an object and blend, or transition into each other.
    /// </summary>
    Linear,

    /// <summary>Radial gradient: the transition between color stops is a circular pattern.</summary>
    Radial,

    /// <summary>
    /// Angular gradient: sweeps around the circumference.
    /// </summary>
    Angular
}