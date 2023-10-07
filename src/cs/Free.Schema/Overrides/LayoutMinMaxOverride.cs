namespace Free.Schema;

public sealed class LayoutMinMaxOverride : NodeOverride
{
    public float MinWidth { get; set; }
    public float MinHeight { get; set; }
    public float MaxWidth { get; set; } = float.PositiveInfinity;
    public float MaxHeight { get; set; } = float.PositiveInfinity;

    public override OverrideType Type => OverrideType.LayoutMinMax;
}