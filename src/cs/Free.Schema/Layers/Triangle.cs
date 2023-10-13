namespace Free.Schema;

public class Triangle : Path
{
    public override string Type => "TRIANGLE";
    
    public bool Equilateral { get; set; }
}