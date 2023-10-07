namespace Free.Schema;

public sealed class EndArrowheadOverride : NodeOverride
{
    public Arrowhead Value { get; set; }

    public override OverrideType Type => OverrideType.EndArrowhead;
}