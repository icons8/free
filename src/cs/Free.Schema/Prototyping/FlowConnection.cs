namespace Free.Schema;

public class FlowConnection
{
    public FlowAnimationType PrototypingAnimationType { get; set; } = FlowAnimationType.FromRight;

    public string DestinationArtboardId { get; set; } = string.Empty;

    public string? InitialDestinationArtboardId { get; set; }

    public bool MaintainScrollPosition { get; set; }
}