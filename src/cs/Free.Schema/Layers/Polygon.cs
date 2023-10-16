namespace Free.Schema;

public class Polygon : Path
{
    public override string _t => "POLYGON";
    
    /// <summary>
    /// Number of corners
    /// </summary>
    public float Rays { get; set; }
}