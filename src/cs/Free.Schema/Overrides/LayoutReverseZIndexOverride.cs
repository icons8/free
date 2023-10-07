namespace Free.Schema;

public sealed class LayoutReverseZIndexOverride : NodeOverride
{
    public bool IsReverseZIndex { get; set; }

    public override OverrideType Type => OverrideType.LayoutReverseZIndex;
}