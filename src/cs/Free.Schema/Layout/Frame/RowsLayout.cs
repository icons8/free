namespace Free.Schema;

public class RowsLayout : IFrameLayout
{
    public bool Enabled { get; set; }
    public int GutterHeight { get; set; }
    public int RowHeight { get; set; }
    public bool DrawHorizontalLines { get; set; }
    public Color Color { get; set; }
}