namespace Free.Schema;

public sealed class LayoutStretchOverride : NodeOverride
{
    public bool IsStretch { get; set; }
    public bool IsGrowStretch { get; set; }

    public override OverrideType Type => OverrideType.LayoutStretch;
}