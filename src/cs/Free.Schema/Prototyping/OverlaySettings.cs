namespace Free.Schema;
/// <summary>
/// Defines overlay settings.
/// </summary>
[SketchCompatibility]
public class OverlaySettings
{
    public Point Offset { get; set; }
    public Point OverlayAnchor { get; set; }
    public OverlayType OverlayType { get; set; }
    public Point SourceAnchor { get; set; }
}