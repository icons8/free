namespace Free.Schema;

public class Polygon : Path
{
    public override string _t => "POLYGON";
    
    public float Rays { get; set; }
}