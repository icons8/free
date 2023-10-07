namespace Free.Schema;

public class InlineStyle
{
    public int Start { get; set; }

    public int Length { get; set; }

    public TextStyle Style { get; } = new();
}