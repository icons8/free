namespace Free.Schema;

public class Path : Styled
{
    public override string _t => "PATH";
    
    public bool Edited { get; set; }
    public bool Open { get; set; }
    public List<Vertex> Points { get; } = new();
    public bool SmoothCorners { get; set; }
}