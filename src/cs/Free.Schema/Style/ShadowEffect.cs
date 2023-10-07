namespace Free.Schema;

public sealed class ShadowEffect
{
    public bool Enabled { get; set; } = true;
    public float Radius { get; set; }
    public Color Color { get; set; }
    public Guid? ColorId { get; set; }
    public float Spread { get; set; }
    public Point Offset { get; set; }
    public float Opacity { get; set; }
    public BlendingMode BlendMode { get; set; }
}