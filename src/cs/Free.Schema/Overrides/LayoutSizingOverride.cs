namespace Free.Schema;

public sealed class LayoutSizingOverride : NodeOverride
{
    public SizingMode Horizontal { get; set; }
    public SizingMode Vertical { get; set; }

    public override OverrideType Type => OverrideType.LayoutSizing;
}