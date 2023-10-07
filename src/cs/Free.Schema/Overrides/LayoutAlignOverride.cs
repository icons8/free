namespace Free.Schema;

public sealed class LayoutAlignOverride : NodeOverride
{
    public HorizontalAlignment Horizontal { get; set; }
    public VerticalAlignment Vertical { get; set; }

    public override OverrideType Type => OverrideType.LayoutAlign;
}