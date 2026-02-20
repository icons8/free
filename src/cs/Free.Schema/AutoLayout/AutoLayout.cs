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
    /// Is width fixed. False = hug or fill if StretchWidth is true.
    /// </summary>
    public bool FixWidth { get; set; }
    /// <summary>
    /// Is height fixed. False = hug or fill if StretchHeight is true.
    /// </summary>
    public bool FixHeight { get; set; }
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
}