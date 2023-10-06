namespace Free.Schema;

public class InlineStyle
{
    public int StartIndex { get; set; }

    public int Length { get; set; }

    public int EndIndex => StartIndex + Length - 1;

    public TextStyle TextStyle { get; } = new();
}