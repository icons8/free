namespace Free.Schema;
/// <summary>
/// A rectangle is a shape drawn on the canvas with the Rectangle tool.
/// </summary>
public class Rectangle : Path
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "RECT";
    
    /// <summary>
    /// If the smooth corners option is enabled. Works only if the rectangle is not edited.
    /// </summary>
    public bool SmoothCorners { get; set; }
}