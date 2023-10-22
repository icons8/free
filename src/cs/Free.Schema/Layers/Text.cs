namespace Free.Schema;
/// <summary>
/// Text is a block or line of text on the canvas.
/// </summary>

public class Text : Styled
{
    public override string _t => "TEXT";
    /// <summary>
    /// The content of the text layer.
    /// </summary>
    public string text { get; set; }
    /// <summary>
    /// The style applied to the text.
    /// </summary>
    public TextStyle TextStyle { get; } = new();
    /// <summary>
    /// Styling options applied to the text within a text block. 
    /// </summary>
    public List<InlineStyle> Inlines { get; } = new();
    /// <summary>
    /// Reserved for future use.?????????
    /// </summary>
    public bool DrawOnPath { get; set; }
    /// <summary>
    /// ????????
    /// </summary>
    public bool StopSync { get; set; }
    /// <summary>
    /// ?????????
    /// </summary>
    public TextBehavior Behavior { get; set; } = TextBehavior.Flexible;
    /// <summary>
    /// Valid for files imported from Figma. Defines whether to truncate text content.
    /// </summary>
    public bool ClipContent { get; set; } = true;
}