namespace Free.Schema;

public class ComponentLayer : FrameLayer
{
    public Guid ComponentId { get; set; }
    public bool BackgroundInInstance { get; set; }
    public bool IsPredefined { get; set; }
    public string ComponentType { get; set; }
}