namespace Free.Schema;

public class Polygon : Path
{
    public override string Type => "POLYGON";
    
    public float Rays { get; set; }
}