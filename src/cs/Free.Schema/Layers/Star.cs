namespace Free.Schema;
/// <summary>
/// A star is a shape drawn on the canvas with the Star tool.
/// </summary>
public class Star : Path
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "STAR";
    
    /// <summary>
    /// Defines the number of rays in a star.
    /// </summary>
    public float Rays { get; set; }
    /// <summary>
    /// Defines the star ratio value.
    /// </summary>
    public float Ratio { get; set; }
}