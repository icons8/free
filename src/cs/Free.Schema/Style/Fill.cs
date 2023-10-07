namespace Free.Schema;

public class Fill
{
    public bool Enabled { get; set; }
    public Color Color { get; set; }
    public Guid? ColorId { get; set; }
    public FillType Type { get; set; }
    public float Opacity { get; set; }
    public BlendingMode BlendMode { get; set; } 

    public Pattern Pattern { get; } = new();
    public Gradient Gradient { get; } = new();
}