namespace Free.Schema;

public class Rulers
{
    public Point Base { get; set; }
    public List<int> Guides { get; set; } = new();
    public List<int> VGuides { get; set; } = new();
}