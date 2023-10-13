namespace Free.Schema;

public class Oval : Path
{
    public override string Type => "OVAL";
    
    public float Angle { get; set; }
    public float Ratio { get; set; }
    public float StartAngle { get; set; }
}