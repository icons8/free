namespace Free.Schema;

public class Fill
{
    public bool Enabled { get; set; }
    public Color Color { get; set; }
    /// <summary>
    /// Color Variable ID
    /// </summary>
    public Guid? ColorId { get; set; }
    public FillType Type { get; set; }
    public float Opacity { get; set; }
    public BlendMode BlendMode { get; set; } 

    public Pattern Pattern { get; } = new();
    public Gradient Gradient { get; } = new();
}