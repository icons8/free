namespace Free.Schema;

public class ColumnsLayout : IFrameLayout
{
    public bool Enabled { get; set; }
    public int TotalWidth { get; set; }
    public int Offset { get; set; }
    public int NumberOfColumns { get; set; }
    public int GutterWidth { get; set; }
    public int ColumnWidth { get; set; }
    public bool GutterOutside { get; set; }
    public Color Color { get; set; }
}