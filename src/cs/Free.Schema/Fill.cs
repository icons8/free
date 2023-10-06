namespace Free.Schema;

public class Fill
{
    public bool IsEnabled { get; set; }
    public Color Color { get; set; }
    public FillType FillType { get; set; }
    public float Opacity { get; set; }
    public BlendingMode BlendMode { get; set; } 
    public Guid? SwatchId { get; set; }

    public Pattern Pattern { get; } = new();
    public Gradient Gradient { get; } = new();
}