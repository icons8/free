namespace Free.Schema;
/// <summary>
/// A rectangle is a shape drawn on the canvas with the Rectangle tool.
/// </summary>
public class Rectangle : Path
{
    public override string _t => "RECT";
    
    /// <summary>
    /// Is Smooth corners enabled. Works only if rectangle is not edited.
    /// </summary>
    public bool SmoothCorners { get; set; }
}