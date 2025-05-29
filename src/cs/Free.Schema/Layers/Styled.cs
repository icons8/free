namespace Free.Schema;
/// <summary>
/// A styled layer is a layer that has layer styling options.
/// </summary>
public abstract class Styled : Layer
{
    /// <summary>
    /// Unique style identifier.
    /// </summary>
    public Guid StyleId { get; set; }
    /// <summary>
    /// Limit on the ratio of the miter length to the stroke-width used to draw a miter joint. When the limit is exceeded, the joint is converted from miter to beveled.
    /// </summary>
    public float MiterLimit { get; set; } = 10;
    /// <summary>
    /// Opacity value.
    /// </summary>
    public float Opacity { get; set; } = 1;
    /// <summary>
    /// Blend mode.
    /// </summary>
    public BlendMode BlendMode { get; set; }
    /// <summary>
    /// Determines the appearance of the tail of an open path drawn with the Line, Arrow, or Pen/Pencil tool. 
    /// </summary>
    public Arrowhead StartMarker { get; set; }
    /// <summary>
    /// Determines the appearance of the head of an open path drawn with the Line, Arrow, or Pen/Pencil tool.
    /// </summary>
    public Arrowhead EndMarker { get; set; }
    /// <summary>
    /// Defines the filling options for overlapping paths.
    /// </summary>
    public PathFillType Winding { get; set; } = PathFillType.EvenOdd;
    /// <summary>
    /// Defines the tint color.
    /// </summary>
    public Fill? Tint { get; set; }
    /// <summary>
    /// List of fills.
    /// </summary>
    public List<Fill> Fills { get; } = new();
    /// <summary>
    /// List of borders.
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
    /// List of shadows.
    /// </summary>
    public List<ShadowEffect> Shadows { get; } = new();
    /// <summary>
    /// List of inner shadows.
    /// </summary>
    public List<ShadowEffect> InnerShadows { get; } = new();
    /// <summary>
    /// Information about blurs.
    /// </summary>
    public BlurEffect Blur { get; } = new();
    /// <summary>
    /// Filters applied to an image (hue, saturartion, etc.), if any.
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