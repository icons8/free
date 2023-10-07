namespace Free.Schema;

public sealed class LayoutWrapDistributeOverride : NodeOverride
{
    public bool Value { get; set; }

    public override OverrideType Type => OverrideType.LayoutWrapDistribute;
}