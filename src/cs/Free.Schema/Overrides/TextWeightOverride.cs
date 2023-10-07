namespace Free.Schema;

public sealed class TextWeightOverride : NodeOverride
{
    public float Slant { get; set; }
    public float Proportion { get; set; }
    public float Symbolic { get; set; }
    public float Weight { get; set; }

    public override OverrideType Type => OverrideType.TextWeight;
}