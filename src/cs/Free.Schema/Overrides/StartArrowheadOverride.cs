namespace Free.Schema;

public sealed class StartArrowheadOverride : NodeOverride
{
    public Arrowhead Start { get; set; }

    public override OverrideType Type => OverrideType.StartArrowhead;
}