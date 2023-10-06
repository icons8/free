namespace Free.Schema;

public abstract class StyledLayer : Layer
{
    public Guid StyleId { get; set; }
    public Style Style { get; } = new();
}