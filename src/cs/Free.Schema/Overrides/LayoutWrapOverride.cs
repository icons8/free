namespace Free.Schema;

public sealed class LayoutWrapOverride : NodeOverride
{
    public bool Value { get; set; }

    public override OverrideType Type => OverrideType.LayoutWrap;
}