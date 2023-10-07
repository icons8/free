namespace Free.Schema;

public sealed class BlendingOverride : NodeOverride
{
    public float Opacity { get; set; } = 1;
    public BlendingMode BlendMode { get; set; }

    public override OverrideType Type => OverrideType.Blending;
}