namespace Free.Schema;

/// <summary>Enumeration of the type of a Gradient.</summary>
public enum GradientType : byte
{
    /// <summary>Linear gradients tend to be the most common, where two colors will appear at opposite points of an object and will blend, or transition into each other.</summary>
    Linear,

    /// <summary>A radial gradient will create an effect where the transition between color stops will be in a circular pattern.</summary>
    Radial,

    /// <summary>This effect allows you to create gradients that sweep around the circumference (measured by the maximum width or height of a layer) in a clockwise direction.</summary>
    Angular
}