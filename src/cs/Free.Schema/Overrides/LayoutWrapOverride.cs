namespace Free.Schema;

public sealed class LayoutWrapOverride : NodeOverride
{
    public bool IsWrap { get; set; }

    public override OverrideType Type => OverrideType.LayoutWrap;
}