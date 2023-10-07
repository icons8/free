namespace Free.Schema;

public sealed class StringValueOverride : NodeOverride
{
    public string? Text { get; set; }

    public override OverrideType Type => OverrideType.StringValue;
}