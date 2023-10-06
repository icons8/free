namespace Free.Schema;

public class SliceLayer : Layer
{
    public bool HasBackgroundColor { get; set; }
    public Color BackgroundColor { get; set; }
    public Guid BackgroundId { get; set; }
}