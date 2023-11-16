namespace Free.Schema;

/// <summary>
/// Sketch Group Layout Properties
/// </summary>
[SketchCompatibility]
public class SketchGroupLayout
{
    /// <summary>
    /// Layout Orientation
    /// </summary>
    public GroupLayoutAxis Axis { get; set; } = GroupLayoutAxis.Horizontal;
    /// <summary>
    /// Layout Align
    /// </summary>
    public GroupLayoutAnchor LayoutAnchor { get; set; } = GroupLayoutAnchor.Begin;
    /// <summary>
    /// Maximum Container Size
    /// </summary>
    public float MaxSize { get; set; }
    /// <summary>
    /// Minimum Container Size
    /// </summary>
    public float MinSize { get; set; }
}