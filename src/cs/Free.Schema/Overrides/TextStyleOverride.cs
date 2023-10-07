namespace Free.Schema;

public sealed class TextStyleOverride : NodeOverride
{
    public Guid StyleId { get; set; }
    public override OverrideType Type => OverrideType.TextStyle;
}