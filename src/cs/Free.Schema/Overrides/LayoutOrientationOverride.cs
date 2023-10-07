namespace Free.Schema;

public sealed class LayoutOrientationOverride : NodeOverride
{
    public LayoutOrientation Value { get; set; }

    public override OverrideType Type => OverrideType.LayoutOrientation;
}