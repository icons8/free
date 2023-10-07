namespace Free.Schema;

public sealed class LayoutReverseZIndexOverride : NodeOverride
{
    public bool Value { get; set; }

    public override OverrideType Type => OverrideType.LayoutReverseZIndex;
}