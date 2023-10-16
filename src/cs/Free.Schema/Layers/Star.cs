namespace Free.Schema;

public class Star : Path
{
    public override string _t => "STAR";
    
    /// <summary>
    /// number of rays in star
    /// </summary>
    public float Rays { get; set; }
    public float Ratio { get; set; }
}