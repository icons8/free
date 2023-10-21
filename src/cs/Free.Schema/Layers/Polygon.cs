namespace Free.Schema;

public class Polygon : Path
{
    public override string _t => "POLYGON";
    
    /// <summary>
    /// Defines the number of corners.
    /// </summary>
    public float Rays { get; set; }
}