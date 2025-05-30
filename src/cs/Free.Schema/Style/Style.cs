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
    public List<Fill> Borders { get; } = new();
    /// <summary>
    /// Defines border thickness.
    /// </summary>
    public float Thickness { get; set; }
    /// <summary>
    /// Defines custom border thickness.
    /// </summary>
    public Thickness CustomThickness { get; set; }
    /// <summary>
    /// Defines border position.
    /// </summary>
    public LinePosition LinePos { get; set; } = LinePosition.Center;
    /// <summary>
    /// Defines the shape of line caps.
    /// </summary>
    public LineCap LineCap { get; set; } = LineCap.Butt;
    /// <summary>
    /// Defines the appearance of line folds.
    /// </summary>
    public LineJoin LineJoin { get; set; } = LineJoin.Miter;
    /// <summary>
    /// Defines the size of dashes.
    /// </summary>
    public float[] Dash { get; set; }
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
    /// Image filters applied to a layer.
    /// </summary>
    public ImageFilters ImageFilters { get; } = new();
    /// <summary>
    /// Sets the corner radius of the frame/instance/component/states/section.
    /// </summary>
    public float[] CornerRadius { get; set; } = new float[4];
    /// <summary>
    /// Enables smooth rounded corners like in iOS interfaces.
    /// </summary>
    public bool SmoothCorners { get; set; }
}