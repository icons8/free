namespace Free.Schema;

public class Text : Styled
{
    public override string _t => "TEXT";
    
    public string text { get; set; }
    public TextStyle TextStyle { get; } = new();
    public List<InlineStyle> Inlines { get; } = new();
    public bool DrawOnPath { get; set; }
    public bool StopSync { get; set; }
    public TextBehavior Behavior { get; set; } = TextBehavior.Flexible;
    /// <summary>
    /// after import from figma
    /// </summary>
    public bool ClipContent { get; set; } = true;
}