namespace Free.Schema;

public sealed class CornerRadiusOverride : NodeOverride
{
    public float[] CornerRadius { get; set; } = Array.Empty<float>();
    public override OverrideType Type => OverrideType.CornerRadius;
}