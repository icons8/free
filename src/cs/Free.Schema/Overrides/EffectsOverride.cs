namespace Free.Schema;

public sealed class EffectsOverride : NodeOverride
{
    public List<ShadowEffect> Shadows { get; } = new();
    public List<ShadowEffect> InnerShadows { get; } = new();
    public BlurEffect Blur { get; } = new();

    public override OverrideType Type => OverrideType.Effects;
}