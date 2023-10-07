namespace Free.Schema;

public class Slice : Layer
{
    public bool HasBackground { get; set; }
    public Color Background { get; set; }
    public Guid? BackgroundId { get; set; }
}