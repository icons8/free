namespace Free.Schema;

public class Grid : IGridLayout
{
    public string _t => "GRID";
    
    public bool Enabled { get; set; }
    public Color Color { get; set; }
    public int Size { get; set; } = 10;
    [SketchCompatibility]
    public int ThickTimes { get; set; } = 10;
}