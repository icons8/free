namespace Free.Schema;

public class Star : Path
{
    public override string _t => "STAR";
    
    public float Rays { get; set; }
    public float Ratio { get; set; }
}