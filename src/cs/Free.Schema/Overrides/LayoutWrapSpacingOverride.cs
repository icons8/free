namespace Free.Schema;

public sealed class LayoutWrapSpacingOverride : NodeOverride
{
    public float Value { get; set; }

    public override OverrideType Type => OverrideType.LayoutWrapSpacing;
}