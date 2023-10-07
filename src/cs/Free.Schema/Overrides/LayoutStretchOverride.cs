namespace Free.Schema;

public sealed class LayoutStretchOverride : NodeOverride
{
    public bool LayoutStretch { get; set; }
    public bool LayoutGrowStretch { get; set; }

    public override OverrideType Type => OverrideType.LayoutStretch;
}