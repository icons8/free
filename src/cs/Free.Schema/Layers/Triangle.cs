namespace Free.Schema;
/// <summary>
/// A triangle is a shape drawn on the canvas with the Triangle tool.
/// </summary>
public class Triangle : Path
{
    public override string _t => "TRIANGLE";
    
    public bool Equilateral { get; set; }
}