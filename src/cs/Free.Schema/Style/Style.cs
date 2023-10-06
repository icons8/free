namespace Free.Schema;

public class Style
{
    public int MiterLimit { get; set; } = 10;
    public float Opacity { get; set; } = 1;
    public BlendingMode BlendMode { get; set; }
    public Arrowhead StartArrowhead { get; set; }
    public Arrowhead EndArrowhead { get; set; }
    public FillType WindingRule { get; set; } = FillType.EvenOdd;

    public Fill? Tint { get; set; }
    public Fill[] Fills { get; } = Array.Empty<Fill>();
    public Border[] Borders { get; } = Array.Empty<Border>();
    public ShadowEffect[] Shadows { get; } = Array.Empty<ShadowEffect>();
    public ShadowEffect[] InnerShadows { get; } = Array.Empty<ShadowEffect>();

    public BlurEffect Blur { get; } = new BlurEffect();
    public BorderOptions BorderOptions { get; } = new BorderOptions();
    public ImageFilters ImageFilters { get; } = new ImageFilters();
}