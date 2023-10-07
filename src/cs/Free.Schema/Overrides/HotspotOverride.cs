namespace Free.Schema;

public sealed class HotspotOverride : NodeOverride
{
    public string? DestinationArtboardId { get; set; }

    public override OverrideType Type => OverrideType.Hotspot;
}