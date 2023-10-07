namespace Free.Schema;

public sealed class TextStyleOverride : NodeOverride
{
    public Guid SharedStyleId { get; set; }
    public override OverrideType Type => OverrideType.TextStyle;
}