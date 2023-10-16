namespace Free.Schema;

public class Columns : IGridLayout
{
    public string _t => "COLS";
    
    public bool Enabled { get; set; }
    public LayoutHorizontalAlignment Align { get; set; }
    public int Offset { get; set; }
    public int Count { get; set; }
    public int Gutter { get; set; }
    public int Width { get; set; }
    public Color Color { get; set; }
}