namespace Free.Schema;

public sealed class LayoutTextBaselineOverride : NodeOverride
{
    public bool Value { get; set; }

    public override OverrideType Type => OverrideType.LayoutTextBaseline;
}