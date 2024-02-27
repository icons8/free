namespace Free.Schema;
/// <summary>
/// A triangle is a shape drawn on the canvas with the Triangle tool.
/// </summary>
public class Triangle : Path
{
    public override string _t => "TRIANGLE";
    
    /// <summary>
    /// if the triangle is equilateral.
    /// </summary>
    [SketchCompatibility]
    public bool Equilateral { get; set; }
}