namespace Free.Schema;

public class AutoLayoutContainer : ILayoutContainer
{
    public string _t => "AUTO";
    
    public LayoutOrientation Orientation { get; set; }
    public float Spacing { get; set; }
    public float WrapSpacing { get; set; }
    public Thickness Padding { get; set; }
    public HorizontalAlignment Align { get; set; }
    public VerticalAlignment Valign { get; set; }
    public SizingMode Sizing { get; set; }
    public SizingMode Vsizing { get; set; }
    public bool TextBaseline { get; set; }
    public bool StrokesIncluded { get; set; }
    public bool ReverseZIndex { get; set; }
    public bool Wrap { get; set; }
    public bool WrapDistribute { get; set; }
}