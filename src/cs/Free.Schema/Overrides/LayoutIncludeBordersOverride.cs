namespace Free.Schema;

public sealed class LayoutIncludeBordersOverride : NodeOverride
{
    public bool IncludeBorders { get; set; }

    public override OverrideType Type => OverrideType.LayoutIncludeBorders;
}