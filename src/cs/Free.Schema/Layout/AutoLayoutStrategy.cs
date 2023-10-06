namespace Free.Schema;

public class AutoLayoutStrategy : LayoutStrategy
{
    public LayoutOrientation Orientation { get; set; }
    public float Spacing { get; set; }
    public float WrapSpacing { get; set; }
    public Thickness Padding { get; set; }
    public HorizontalAlignment HorizontalAlignment { get; set; }
    public VerticalAlignment VerticalAlignment { get; set; }
    public SizingMode HorizontalSizing { get; set; }
    public SizingMode VerticalSizing { get; set; }
    public bool IsTextBaselineAlignment { get; set; }
    public bool IncludeBorders { get; set; }
    public bool IsItemReverseZIndex { get; set; }
    public bool IsWrap { get; set; }
    public bool IsWrapDistribute { get; set; }
}