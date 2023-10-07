namespace Free.Schema;

public sealed class LayoutSpacingOverride : NodeOverride
{
    public float Spacing { get; set; }

    public override OverrideType Type => OverrideType.LayoutSpacing;
}