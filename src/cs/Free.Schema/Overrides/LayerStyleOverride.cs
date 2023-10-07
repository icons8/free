namespace Free.Schema;

public sealed class LayerStyleOverride : NodeOverride
{
    public Guid StyleId { get; set; }
    public override OverrideType Type => OverrideType.LayerStyle;
}