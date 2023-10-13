namespace Free.Schema;

public class Slice : Layer
{
    public override string Type => "SLICE";
    
    public bool HasBackground { get; set; }
    public Color Background { get; set; }
    public Guid? BackgroundId { get; set; }
}