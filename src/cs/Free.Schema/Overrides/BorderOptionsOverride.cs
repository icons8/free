namespace Free.Schema;

public sealed class BorderOptionsOverride : NodeOverride
{
    public BorderOptions BorderOptions { get; } = new();
    public override OverrideType Type => OverrideType.BorderOptions;
}