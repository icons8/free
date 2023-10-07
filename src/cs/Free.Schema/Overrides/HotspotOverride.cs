namespace Free.Schema;

public sealed class HotspotOverride : NodeOverride
{
    public string? Link { get; set; }

    public override OverrideType Type => OverrideType.Hotspot;
}