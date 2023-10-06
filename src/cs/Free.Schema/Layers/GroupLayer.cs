namespace Free.Schema;

public class GroupLayer : StyledLayer
{
    public bool SkipSelect { get; set; }
    public bool SkipConstraints { get; set; }
    public GroupLayoutBase? GroupLayout { get; set; }
    public List<Layer> Layers { get; } = new();
}