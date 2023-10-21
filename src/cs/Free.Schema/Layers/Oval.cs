namespace Free.Schema;

public class Oval : Path
{
    public override string _t => "OVAL";
    /// <summary>
    /// End angle for donuts measured clockwise from the X axis.
    /// </summary>
    public float Angle { get; set; }
    /// <summary>
    /// Inner radius for donuts.
    /// </summary>
    public float Ratio { get; set; }
    /// <summary>
    /// Start angle for donuts measured clockwise from the X axis.
    /// </summary>
    public float StartAngle { get; set; }
}