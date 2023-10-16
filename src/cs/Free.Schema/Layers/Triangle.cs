namespace Free.Schema;

public class Triangle : Path
{
    public override string _t => "TRIANGLE";
    
    public bool Equilateral { get; set; }
}