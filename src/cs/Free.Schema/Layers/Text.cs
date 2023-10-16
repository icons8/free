namespace Free.Schema;

public class Text : Styled
{
    public override string _t => "TEXT";
    
    public string text { get; set; }
    public TextStyle TextStyle { get; } = new();
    public List<InlineStyle> Inlines { get; } = new();
    public bool DrawOnPath { get; set; }
    public bool StopSync { get; set; }
    public LineSpacingBehavior LineSpacingBehavior { get; set; } = LineSpacingBehavior.ConstantBaseline;
    public TextBehavior Behavior { get; set; } = TextBehavior.Flexible;
    public bool ClipContent { get; set; } = true;
}