namespace Free.Schema;

public sealed class LayoutSpacingOverride : NodeOverride
{
    public float Value { get; set; }

    public override OverrideType Type => OverrideType.LayoutSpacing;
}