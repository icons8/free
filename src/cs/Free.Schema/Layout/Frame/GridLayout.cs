namespace Free.Schema;

public class GridLayout : IFrameLayout
{
    public bool Enabled { get; set; }
    public Color Color { get; set; }
    public int Size { get; set; } = 10;
    public int ThickTimes { get; set; } = 10;
}