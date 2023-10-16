namespace Free.Schema;

public class Style
{
    public int MiterLimit { get; set; } = 10;
    public float Opacity { get; set; } = 1;
    public BlendMode BlendMode { get; set; }
    public Arrowhead StartMarker { get; set; }
    public Arrowhead EndMarker { get; set; }
    public PathFillType Winding { get; set; } = PathFillType.EvenOdd;

    public Fill? Tint { get; set; }
    public List<Fill> Fills { get; } = new();
    public List<Border> Borders { get; } = new();
    public List<ShadowEffect> Shadows { get; } = new();
    public List<ShadowEffect> InnerShadows { get; } = new();

    public BlurEffect Blur { get; } = new();
    public BorderOptions BorderOptions { get; } = new();
    public ImageFilters ImageFilters { get; } = new();
}