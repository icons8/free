namespace Free.Schema;

public class Star : Path
{
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