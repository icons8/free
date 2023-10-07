namespace Free.Schema;

public sealed class LayoutPaddingOverride : NodeOverride
{
    public float Left { get; set; }
    public float Top { get; set; }
    public float Right { get; set; }
    public float Bottom { get; set; }

    public override OverrideType Type => OverrideType.LayoutPadding;
}