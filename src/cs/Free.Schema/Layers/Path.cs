namespace Free.Schema;

public class Path : Styled
{
    public override string Type => "PATH";
    
    public bool Edited { get; set; }
    public bool Closed { get; set; }
    public List<Vertex> Points { get; } = new();
    public RadiusBehavior RadiusBehavior { get; set; }
}