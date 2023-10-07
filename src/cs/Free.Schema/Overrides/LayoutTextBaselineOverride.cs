namespace Free.Schema;

public sealed class LayoutTextBaselineOverride : NodeOverride
{
    public bool IsTextBaseline { get; set; }

    public override OverrideType Type => OverrideType.LayoutTextBaseline;
}