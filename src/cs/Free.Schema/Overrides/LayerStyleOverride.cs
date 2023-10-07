namespace Free.Schema;

public sealed class LayerStyleOverride : NodeOverride
{
    public Guid SharedStyleId { get; set; }
    public override OverrideType Type => OverrideType.LayerStyle;
}