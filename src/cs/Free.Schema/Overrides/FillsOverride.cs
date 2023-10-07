namespace Free.Schema;

public sealed class FillsOverride : NodeOverride
{
    public List<Fill> Fills { get; } = new();
    public override OverrideType Type => OverrideType.Fills;
}