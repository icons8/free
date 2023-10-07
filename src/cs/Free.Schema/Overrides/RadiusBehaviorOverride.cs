namespace Free.Schema;

public sealed class RadiusBehaviorOverride : NodeOverride
{
    public RadiusBehavior RadiusBehavior { get; set; }

    public override OverrideType Type => OverrideType.RadiusBehavior;
}