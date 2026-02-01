namespace Free.Schema;
/// <summary>
/// Defines square grid settings for a frame.
/// </summary>
public sealed class Grid : LayoutGuideBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public string _t => "GRID";
    /// <summary>
    /// If the square grid is enabled.
    /// </summary>
    public bool Enabled { get; set; }
    /// <summary>
    /// Grid color.
    /// </summary>
    public Color Color { get; set; }
    /// <summary>
    /// Size of grid cells.
    /// </summary>
    public int Size { get; set; } = 10;
    /// <summary>
    /// Every N line should be thick.
    /// </summary>
    [SketchCompatibility]
    public int ThickTimes { get; set; } = 10;
}