namespace Free.Schema;

public sealed class EndArrowheadOverride : NodeOverride
{
    public Arrowhead End { get; set; }

    public override OverrideType Type => OverrideType.EndArrowhead;
}