namespace Free.Schema;

public class Component : Frame
{
    public override string Type => "COMPONENT";
    public Guid ComponentId { get; set; }
    public bool BackgroundInInstance { get; set; }
    public bool Predefined { get; set; }
    public string ComponentType { get; set; }
}