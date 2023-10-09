namespace Free.Schema.Document;

public class Page
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Color Background { get; set; }
    public bool IsComponentPage { get; set; }
    public Rulers Rulers { get; } = new();
    public Point Origin { get; set; }
    public float Zoom { get; set; }
    public List<Layer> Layers { get; } = new();
}