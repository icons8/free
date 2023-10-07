namespace Free.Schema;

public sealed class StarRatioOverride : NodeOverride
{
    public float StarRatio { get; set; }

    public override OverrideType Type => OverrideType.StarRatio;
}