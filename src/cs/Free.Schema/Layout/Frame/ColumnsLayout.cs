namespace Free.Schema;

public class ColumnsLayout : IFrameLayout
{
    public bool Enabled { get; set; }
    public int TotalWidth { get; set; }
    public int Offset { get; set; }
    public int Count { get; set; }
    public int Gutter { get; set; }
    public int Width { get; set; }
    public bool GutterOutside { get; set; }
    public Color Color { get; set; }
}