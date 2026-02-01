namespace Free.Schema;
/// <summary>
/// Defines auto layout settings. 
/// </summary>
public class AutoLayout
{
    /// <summary>
    /// Is vertical orientation.
    /// </summary>
    public bool Vertical { get; set; }
    /// <summary>
    /// Spacing value
    /// </summary>
    public float Spacing { get; set; }
    /// <summary>
    /// Spacing between rows of wrapped content.
    /// </summary>
    public float WrapSpacing { get; set; }
    /// <summary>
    /// Padding value.
    /// </summary>
    public Thickness Padding { get; set; }
    /// <summary>
    /// Horizontal children alignment
    /// </summary>
    public HorizontalAlignment Align { get; set; }
    /// <summary>
    /// Vertical children alignment
    /// </summary>
    public VerticalAlignment Valign { get; set; }
    /// <summary>
    /// Is sizing fixed horizontally. False = hug or fill based on Layer.LayoutStretch or Layer.LayoutGrowStretch.
    /// </summary>
    public bool FixedHorizontal { get; set; }
    /// <summary>
    /// Is sizing fixed vertically. False = hug or fill based on Layer.LayoutStretch or Layer.LayoutGrowStretch.
    /// </summary>
    public bool FixedVertical { get; set; }
    /// <summary>
    /// If text baseline alignment is enabled.
    /// </summary>
    public bool TextBaseline { get; set; }
    /// <summary>
    /// If the Include Borders option is enabled.
    /// </summary>
    public bool StrokesIncluded { get; set; }
    /// <summary>
    /// If the Last on Top option is enabled.
    /// </summary>
    public bool ReverseZIndex { get; set; }
    /// <summary>
    /// If wrapping is enabled.
    /// </summary>
    public bool Wrap { get; set; }
    /// <summary>
    /// If auto distribute is enabled for wrapped content.
    /// </summary>
    public bool WrapDistribute { get; set; }
}