namespace Free.Schema;

public class PathLayer : StyledLayer
{
    public bool IsEdited { get; set; }
    public bool IsClosed { get; set; }
    public List<Vertex> Points { get; } = new();
    public RadiusBehavior RadiusBehavior { get; set; }
}