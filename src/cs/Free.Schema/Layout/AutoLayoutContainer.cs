namespace Free.Schema;
/// <summary>
/// Defines auto layout settings. 
/// </summary>
public class AutoLayoutContainer : ILayoutContainer
{
    public string _t => "AUTO";
    /// <summary>
    /// Layout orientation: horizontal or vertical.
    /// </summary>
    public LayoutOrientation Orientation { get; set; }
    /// <summary>
    /// Spacing value
    /// </summary>
    public float Spacing { get; set; }
    public float WrapSpacing { get; set; }
    /// <summary>
    /// Padding value.
    /// </summary>
    public Thickness Padding { get; set; }
    /// <summary>
    /// Horizontal alignment settings.???
    /// </summary>
    public HorizontalAlignment Align { get; set; }
    /// <summary>
    /// Vertical alignment settings.???
    /// </summary>
    public VerticalAlignment Valign { get; set; }
    /// <summary>
    /// Horizontal resizing mode: fixed or hug.???
    /// </summary>
    public SizingMode Sizing { get; set; }
    /// <summary>
    /// Vertical resizing mode: fixed or hug.???
    /// </summary>
    public SizingMode Vsizing { get; set; }
    /// <summary>
    /// If text baseline alignment is enabled.
    /// </summary>
    public bool TextBaseline { get; set; }
    /// <summary>
    /// If the Include Borders option is enabled.
    /// </summary>
    public bool StrokesIncluded { get; set; }
    /// <summary>
    /// If the Last on Top option is enabled. ???
    /// </summary>
    public bool ReverseZIndex { get; set; }
    /// <summary>
    /// If wrapping is enabled.
    /// </summary>
    public bool Wrap { get; set; }
    /// <summary>
    /// Spacing between rows of wrapped content.
    /// </summary>
    public bool WrapDistribute { get; set; }
}