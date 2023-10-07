namespace Free.Schema;

public sealed class LayoutWrapDistributeOverride : NodeOverride
{
    public bool IsWrapDistribute { get; set; }

    public override OverrideType Type => OverrideType.LayoutWrapDistribute;
}