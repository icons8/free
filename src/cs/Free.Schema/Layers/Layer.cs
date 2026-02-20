namespace Free.Schema;

/// <summary>
/// Base class for any layer on a canvas.
/// </summary>
public abstract class Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
    public abstract string _t { get; }
    /// <summary>
    /// Unique layer identifier.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Defines layer name.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Defines the boolean operation applied to the layer.
    /// </summary>
    public BoolOp BoolOp { get; set; }
    /// <summary>
    /// If the *Fix position* option is enabled: the layer preserves its position when you scroll a prototype (for instance, a floating button).
    /// </summary>
    public bool Fixed { get; set; }
    /// <summary>
    /// Defines whether the layer is locked for editing.
    /// </summary>
    public bool Locked { get; set; }
    /// <summary>
    /// Defines whether the layer is hidden.
    /// </summary>
    public bool Hidden { get; set; }
    /// <summary>
    /// Defines whether tha layer is marked as a template.
    /// </summary>
    public bool IsTemplate { get; set; }
    /// <summary>
    /// Defines whether the layer is expanded in Layer List.
    /// </summary>
    public bool Expand { get; set; }
    /// <summary>
    /// When enabled, trims empty pixels in exported images.
    /// </summary>
    public bool Trim { get; set; }
    /// <summary>
    /// Export options of the layer.
    /// </summary>
    public List<ExportOption> Export { get; } = new();

    /// <summary>
    /// Defines constraint settings of the layer. String with chars where every char means a flag:
    /// L - left, T - top, R - right, B - bottom, W - fix width, H - fix height.
    /// </summary>
    public string Constraints { get; set; } = "LTWH";
    /// <summary>
    /// Position, rotation and flips of an object, stored in a single 3x2 matrix, as 2 or 6 floats array.
    /// </summary>
    public Matrix Transform { get; set; } = Matrix.Identity;
    /// <summary>
    /// Optional Field. Defines position. Overrides Transform field. Only for LLM and Plugins.
    /// </summary>
    public Point Pos { get; set; } = new(0, 0);
    /// <summary>
    /// Defines the layer size.
    /// </summary>
    public Size Size { get; set; } = new(100, 100);
    /// <summary>
    /// Optional Field. Defines position and size with one field. Overrides Transform, Pos and Size fields. Only for LLM and Plugins.
    /// </summary>
    public Rect Frame { get; set; } = new(0, 0, 100, 100);
    /// <summary>
    /// Defines whether the layer's aspect ratio should remain unchanged upon resizing.
    /// </summary>
    public bool LockAspect { get; set; }
    
    /// <summary>
    /// Defines whether the layer is used as a mask.
    /// </summary>
    public bool Mask { get; set; }
    /// <summary>
    /// Defines if the layer is set to ignore the mask.
    /// </summary>
    public bool BreakMask { get; set; }
    /// <summary>
    /// Type of the Mask - Vector, Alpha or Luminance.
    /// </summary>
    public MaskType MaskType { get; set; }
    
    /// <summary>
    /// If the *Keep scroll position* option is enabled (prototyping).
    /// </summary>
    public bool KeepScroll { get; set; }
    /// <summary>
    /// Defines scroll behavior (prototyping).
    /// </summary>
    public FlowScrollBehavior ScrollBehavior { get; set; }
    /// <summary>
    /// Defines scroll overflow (prototyping).
    /// </summary>
    public FlowScrollOverflow ScrollOverflow { get; set; }
    /// <summary>
    /// Defines flows (prototyping).
    /// </summary>
    public List<Flow> Flows { get; } = new();
    /// <summary>
    /// Defines the minimum layer width (auto layout).
    /// </summary>
    public float MinWidth { get; set; }
    /// <summary>
    /// Defines the minimum layer height (auto layout).
    /// </summary>
    public float MinHeight { get; set; }
    /// <summary>
    /// Defines the maximum layer width (auto layout).
    /// </summary>
    public float MaxWidth { get; set; }
    /// <summary>
    /// Defines the maximum layer height (auto layout).
    /// </summary>
    public float MaxHeight { get; set; }
    /// <summary>
    /// Determines if the layer should stretch width (auto layout).
    /// </summary>
    public bool StretchWidth { get; set; }
    /// <summary>
    /// Determines whether a layer should stretch height (auto layout).
    /// </summary>
    public bool StretchHeight { get; set; }
    /// <summary>
    /// Enables absolute position for the layer (auto layout).
    /// </summary>
    public bool AbsolutePos { get; set; }
    /// <summary>
    /// Key/Value map for custom properties of a layer. Similar to UserInfo is Sketch and PluginData in Figma.
    /// </summary>
    public Dictionary<string, string> Custom { get; set; } = new();
    
    /// <summary>
    /// Variable themes selections.
    /// </summary>
    public List<ThemeSelection> Themes { get; } = new();
    
    /// <summary>
    /// Binds of variables to target fields like: fontSize, cornerRadius, thickness, etc.
    /// </summary>
    public List<Variable> Binds { get; } = new();
    
    /// <summary>
    /// Identifier of a photo from the Lunacy gallery.
    /// </summary>
    [LunacySpecific]
    public string? PhotoId { get; set; }
    /// <summary>
    /// Identifier of an illustraion from the Lunacy gallery.
    /// </summary>
    [LunacySpecific]
    public string? IllustrationId { get; set; }

    /// <summary>
    /// Identifier of an icon from the Lunacy gallery.
    /// </summary>
    [LunacySpecific]
    public string? IconId { get; set; }
    /// <summary>
    /// Identifier of a Lunacy-generated avatar.
    /// </summary>
    [LunacySpecific]
    public string? AvatarId { get; set; }
    /// <summary>
    /// Information about auto generated texts.
    /// </summary>
    [LunacySpecific]
    public DataInfo? Data { get; set; }
    /// <summary>
    /// If the image has been upscaled in Lunacy.
    /// </summary>
    [LunacySpecific]
    public bool Upscaled { get; set; }
    /// <summary>
    /// Background removal procedure info.
    /// </summary>
    [LunacySpecific]
    public BackgroundRemovalState BackgroundRemove { get; set; }
    
    /// <summary>
    /// Color style id for fills.
    /// </summary>
    public Guid FillsId { get; set; }
    /// <summary>
    /// Color style id for borders.
    /// </summary>
    public Guid BordersId { get; set; }
    /// <summary>
    /// Effect style id.
    /// </summary>
    public Guid EffectsId { get; set; }
    /// <summary>
    /// Opacity value.
    /// </summary>
    public float Opacity { get; set; } = 1;
    /// <summary>
    /// Blend mode.
    /// </summary>
    public BlendMode BlendMode { get; set; }
    /// <summary>
    /// Defines the filling options for overlapping paths.
    /// </summary>
    public PathFillType Winding { get; set; } = PathFillType.EvenOdd;
    /// <summary>
    /// Defines the tint color.
    /// </summary>
    public Fill? Tint { get; set; }
    /// <summary>
    /// If there is a single color fill - use this, otherwise use Fills field.
    /// </summary>
    public Color Fill { get; set; }
    /// <summary>
    /// If there is a single color border - use this, otherwise use Borders field.
    /// </summary>
    public Color Border { get; set; }
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
    public float[] Dash { get; set; } = [];
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