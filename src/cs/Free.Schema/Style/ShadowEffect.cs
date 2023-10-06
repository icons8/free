namespace Free.Schema;

public sealed class ShadowEffect
{
    public float BlurRadius { get; set; }
    public Color Color { get; set; }
    public Guid? SwatchId { get; set; }
    public float Spread { get; set; }
    public float OffsetX { get; set; }
    public float OffsetY { get; set; }
    public bool IsEnabled { get; set; } = true;
    public float Opacity { get; set; }
    public BlendingMode BlendMode { get; set; }
    public bool IsExpanded { get; set; }
}