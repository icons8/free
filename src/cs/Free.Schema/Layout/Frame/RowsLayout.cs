namespace Free.Schema;

public class RowsLayout : IFrameLayout
{
    public bool Enabled { get; set; }
    public int Gutter { get; set; }
    public int Height { get; set; }
    public bool DrawLines { get; set; }
    public Color Color { get; set; }
}