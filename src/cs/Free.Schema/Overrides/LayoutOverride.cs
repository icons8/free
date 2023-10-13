namespace Free.Schema;

public class LayoutOverride
{
    public LayoutOrientation? Orientation { get; set; }
    public float? Spacing { get; set; }
    public float? WrapSpacing { get; set; }
    public Thickness? Padding { get; set; }
    public HorizontalAlignment? Align { get; set; }
    public VerticalAlignment? VAlign { get; set; }
    public SizingMode? Sizing { get; set; }
    public SizingMode? VSizing { get; set; }
    public bool? TextBaseline { get; set; }
    public bool? IncludeBorders { get; set; }
    public bool? ReverseZIndex { get; set; }
    public bool? Stretch { get; set; }
    public bool? GrowStretch { get; set; }
    public bool? Wrap { get; set; }
    public bool? WrapDistribute { get; set; }
}