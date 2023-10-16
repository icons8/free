namespace Free.Schema.Document;

public class Page
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Color Background { get; set; }
    
    public bool IsComponentPage { get; set; }
    /// <summary>
    /// guidelines
    /// </summary>
    public Rulers Rulers { get; } = new();
    
    /// <summary>
    /// point where user was in this page
    /// </summary>
    public Point Origin { get; set; }
    /// <summary>
    /// with which scale user was on this page
    /// </summary>
    public float Zoom { get; set; }
    public List<Layer> Layers { get; } = new();
}