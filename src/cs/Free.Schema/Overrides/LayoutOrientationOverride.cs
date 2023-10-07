namespace Free.Schema;

public sealed class LayoutOrientationOverride : NodeOverride
{
    public LayoutOrientation Orientation { get; set; }

    public override OverrideType Type => OverrideType.LayoutOrientation;
}