namespace Free.Schema;

public sealed class LayoutWrapSpacingOverride : NodeOverride
{
    public float WrapSpacing { get; set; }

    public override OverrideType Type => OverrideType.LayoutWrapSpacing;
}