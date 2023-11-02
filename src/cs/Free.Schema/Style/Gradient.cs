namespace Free.Schema;


/// <summary>
/// An object that represent a gradient.
/// </summary>
public sealed class Gradient
{
    /// <summary>
    /// Type of the gradient.
    /// </summary>
    public GradientType Type { get; set; } = GradientType.Linear;

    /// <summary>
    /// Position of the gradient start point. 
    /// </summary>
             
    public Point From { get; set; } = new(0.5f, 0);

    /// <summary>
    /// Position of the gradient end point. 
    /// </summary>
    public Point To { get; set; } = new(0.5f, 1);
    /// <summary>
    /// Position of the gradient side point. Valid for radial and angular gragients.
    /// </summary>
               
    public Point Side { get; set; }

    /// <summary>
    /// List of other gradient points.
    /// </summary>    
    public List<GradientStop> Stops { get; } = new List<GradientStop>();
}