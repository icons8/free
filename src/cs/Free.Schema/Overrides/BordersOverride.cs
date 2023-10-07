namespace Free.Schema;

public sealed class BordersOverride : NodeOverride
{
    public List<Border> Borders { get; } = new();
    public override OverrideType Type => OverrideType.Borders;
}