namespace Free.Schema;

public class TextLayer : StyledLayer
{
    public string Text { get; set; }
    public TextStyle TextStyle { get; } = new();
    public List<InlineStyle> Inlines { get; } = new();
    public bool AutoDrawOnUnderlyingPath { get; set; }
    public bool DontSyncWithComponent { get; set; }
    public LineSpacingBehavior LineSpacingBehavior { get; set; } = LineSpacingBehavior.ConstantBaseline;
    public TextBehavior Behavior { get; set; } = TextBehavior.AutoResizeHorizontal;
    public bool ClipContent { get; set; } = true;
}