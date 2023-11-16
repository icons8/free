namespace Free.Schema;
/// <summary>
/// Defines a set of properties that make up a style.
/// </summary>
public class Style
{
    /// <summary>
    /// Defining a limit on the ratio of the miter length to the border thickness used to draw a miter join.
    /// </summary>
    public int MiterLimit { get; set; } = 10;
    /// <summary>
    /// Opacity of a layer.
    /// </summary>
    public float Opacity { get; set; } = 1;
    /// <summary>
    /// Blend mode: how a layer blends with the layers behind it.
    /// </summary>
    public BlendMode BlendMode { get; set; }
    /// <summary>
    /// Defines the appearance of the starting point for arrows, lines, and open paths. 
    /// </summary>
    public Arrowhead StartMarker { get; set; }
    /// <summary>
    /// Defines the appearance of the end point for arrows, lines, and open paths. 
    /// </summary>
    public Arrowhead EndMarker { get; set; }
    /// <summary>
    /// Fill options for overlapping paths: non-zero or even-odd.
    /// </summary>
    public PathFillType Winding { get; set; } = PathFillType.EvenOdd;
    /// <summary>
    /// Tint color.
    /// </summary>
    public Fill? Tint { get; set; }
    /// <summary>
    /// List of fills applied to a layer.
    /// </summary>
    public List<Fill> Fills { get; } = new();
    /// <summary>
    /// List of borders applied to a layer.
    /// </summary>
    public List<Border> Borders { get; } = new();
    /// <summary>
    /// List of shadows applied to a layer.
    /// </summary>
    public List<ShadowEffect> Shadows { get; } = new();
    /// <summary>
    /// List of inner shadows applied to a layer.
    /// </summary>
    public List<ShadowEffect> InnerShadows { get; } = new();
    /// <summary>
    /// Definition of the blur effect applied to a layer.
    /// </summary>
    public BlurEffect Blur { get; } = new();
    /// <summary>
    /// Definition of border options.
    /// </summary>
    public BorderOptions BorderOptions { get; } = new();
    /// <summary>
    /// Image filters applied to a layer.
    /// </summary>
    public ImageFilters ImageFilters { get; } = new();
}