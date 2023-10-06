namespace Free.Schema;

public class GridLayout : IFrameLayout
{
    public Color Color { get; set; }
    public int GridSize { get; set; } = 10;
    public int ThickGridTimes { get; set; } = 10;
}