namespace Free.Schema;

public class Rows : IGridLayout
{
    public string _t => "ROWS";
    
    public bool Enabled { get; set; }
    public LayoutVerticalAlignment Align { get; set; }
    public int Offset { get; set; }
    public int Count { get; set; }
    public int Gutter { get; set; }
    public int Width { get; set; }
    public Color Color { get; set; }
}