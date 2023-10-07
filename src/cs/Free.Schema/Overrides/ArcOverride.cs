namespace Free.Schema;

public sealed class ArcOverride : NodeOverride
{
    public float Angle { get; set; }
    public float Ratio { get; set; }
    public float StartAngle { get; set; }

    public override OverrideType Type => OverrideType.Arc;
}