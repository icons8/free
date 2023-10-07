namespace Free.Schema;

public sealed class StartArrowheadOverride : NodeOverride
{
    public Arrowhead Value { get; set; }

    public override OverrideType Type => OverrideType.StartArrowhead;
}