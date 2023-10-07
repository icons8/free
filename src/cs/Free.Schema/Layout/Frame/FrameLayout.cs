namespace Free.Schema;

public class FrameLayout : IFrameLayout
{
    public bool Enabled { get; set; }
    public int TotalWidth { get; set; }
    public int Offset { get; set; }
    public int NumberOfColumns { get; set; }
    
    public int GutterWidth { get; set; }
    public int GutterHeight { get; set; }
    
    public int ColumnWidth { get; set; }
    public int RowHeight { get; set; }

    public bool DrawHorizontal { get; set; }
    public bool DrawVertical { get; set; }
    
    public bool DrawHorizontalLines { get; set; }
    public bool GutterOutside { get; set; }
    
    public Color Color { get; set; }
}