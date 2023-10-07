namespace Free.Schema;

public sealed class LayoutIncludeBordersOverride : NodeOverride
{
    public bool Value { get; set; }

    public override OverrideType Type => OverrideType.LayoutIncludeBorders;
}