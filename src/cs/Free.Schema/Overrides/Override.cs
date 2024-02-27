namespace Free.Schema;
/// <summary>
/// Defines overrides for components.
/// </summary>
public sealed class Override
{
    /// <summary>
    /// List of unique identifiers that determine the target layer, to which an override is applied.
    /// </summary>
    public Guid[] Target { get; set; } = Array.Empty<Guid>();
    /// <summary>
    /// Unique component identifier.
    /// </summary>
    public Guid? ComponentId { get; set; }
    /// <summary>
    /// Export settings.
    /// </summary>  
    public List<ExportOption>? Export { get; set; }

    /// <summary>
    /// Defines the image name used as a fill.
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Defines the target frame (prototyping).
    /// </summary>
    public string? Link { get; set; }
    /// <summary>
    /// If the layer is locked for editing.
    /// </summary>
    public bool? Locked { get; set; }
    /// <summary>
    /// If the layer is hidden.
    /// </summary>
    public bool? Hidden { get; set; }
    /// <summary>
    /// If the clip content feature is enabled.
    /// </summary>
    public bool? ClipContent { get; set; }
    /// <summary>
    /// If the aspect ratio is locked.
    /// </summary>
    public bool? LockAspect { get; set; }
    /// <summary>
    /// Defines the star ratio value.???
    /// </summary>
    public float? Ratio { get; set; }
    /// <summary>
    /// The number of vertices.
    /// </summary>
    public float? VertexCount { get; set; }
    /// <summary>
    /// End angle for donuts measured clockwise from the X axis.
    /// </summary>
    public float? ArcAngle { get; set; }
    /// <summary>
    /// Inner radius for donuts.
    /// </summary>
    public float? ArcRatio { get; set; }
    /// <summary>
    /// Start angle for donuts measured clockwise from the X axis.
    /// </summary>
    public float? ArcStartAngle { get; set; }
    /// <summary>
    /// Corner radius value.
    /// </summary>
    public float[]? CornerRadius { get; set; }
    /// <summary>
    /// If smooth corners are enabled.
    /// </summary>
    public bool SmoothCorners { get; set; }
    /// <summary>
    /// Identifier of the style applied to a layer.
    /// </summary>
    public Guid? StyleId { get; set; }
    /// <summary>
    /// Defines the tint color.
    /// </summary>
    public Color? Tint { get; set; }
    /// <summary>
    /// Tint identifier.
    /// </summary>
    public Guid? TintId { get; set; }
    /// <summary>
    /// List of fills applied to a layer.
    /// </summary>
    public List<Fill>? Fills { get; set; }
    /// <summary>
    /// List of borders applied to a layer.
    /// </summary>
    public List<Border>? Borders { get; set; }
    /// <summary>
    /// Definition of border options.
    /// </summary>
    public BorderOptions? BorderOptions { get; set; }
    /// <summary>
    /// List of shadows.
    /// </summary>
    public List<ShadowEffect>? Shadows { get; set; }
    /// <summary>
    /// List of inner shadows.
    /// </summary>
    public List<ShadowEffect>? InnerShadows { get; set; }
    /// <summary>
    /// Information about blurs.
    /// </summary>
    public BlurEffect? Blur { get; set; }
    /// <summary>
    /// Filters applied to an image (hue, saturartion, etc.), if any.
    /// </summary>
    public ImageFilters? ImageFilters { get; set; }
    /// <summary>
    /// Opacity value.
    /// </summary>
    public float? Opacity { get; set; }
    /// <summary>
    /// Blend mode.
    /// </summary>
    public BlendMode? BlendMode { get; set; }
    /// <summary>
    /// Determines the appearance of the tail of an open path drawn with the Line, Arrow, or Pen/Pencil tool. 
    /// </summary>
    public Arrowhead? StartArrowhead { get; set; }
    /// <summary>
    /// Determines the appearance of the head of an open path drawn with the Line, Arrow, or Pen/Pencil tool.
    /// </summary>
    public Arrowhead? EndArrowhead { get; set; }
    
    //Text

    /// <summary>
    /// Content of the text layer.
    /// </summary>
    public string? Text { get; set; }
    /// <summary>
    /// Style applied to the text
    /// </summary>
    public TextStyle? TextStyle { get; set; }
    /// <summary>
    /// Styling options applied to the text within a text block.
    /// </summary>
    public List<InlineStyle>? Inlines { get; set; }
    /// <summary>
    /// Behavior of the text layer size on text value change: flexible, fixed-width, or fixed.
    /// </summary>
    public TextBehavior? TextBehavior { get; set; }
    /// <summary>
    /// Text size.
    /// </summary>
    public Size? Size { get; set; }

    // Layout

    /// <summary>
    /// Layout orientation: horizontal or vertical.
    /// </summary>
    public LayoutOrientation? Orientation { get; set; }

    /// <summary>
    /// Spacing value
    /// </summary>
    public float? Spacing { get; set; }

    /// <summary>
    /// Spacing between rows of wrapped content.
    /// </summary>
    public float? WrapSpacing { get; set; }

    /// <summary>
    /// Defines the minimum layer width (auto layout).
    /// </summary>
    public float? MinWidth { get; set; }
    /// <summary>
    /// Defines the minimum layer height (auto layout).
    /// </summary>
    public float? MinHeight { get; set; }
    /// <summary>
    /// Defines the maximum layer width (auto layout).
    /// </summary>
    public float? MaxWidth { get; set; }
    /// <summary>
    /// Defines the maximum layer height (auto layout).
    /// </summary>
    public float? MaxHeight { get; set; }
    /// <summary>
    /// Padding value.
    /// </summary>
    public Thickness? Padding { get; set; }
    /// <summary>
    /// Horizontal children alignment.
    /// </summary>
    public HorizontalAlignment? Align { get; set; }
    /// <summary>
    /// Vertical children alignment.
    /// </summary>
    public VerticalAlignment? VAlign { get; set; }
    /// <summary>
    /// Horizontal resizing mode: fixed or hug.
    /// </summary>
    public SizingMode? Sizing { get; set; }
    // <summary>
    /// Vertical resizing mode: fixed or hug.
    /// </summary>
    public SizingMode? VSizing { get; set; }
    /// <summary>
    /// If text baseline alignment is enabled.
    /// </summary>
    public bool? TextBaseline { get; set; }
    /// <summary>
    /// If the Include Borders option is enabled.
    /// </summary>
    public bool? StrokesIncluded { get; set; }
    /// <summary>
    /// If the Last on Top option is enabled.
    /// </summary>
    public bool? ReverseZIndex { get; set; }
    /// <summary>
    /// Determines if the layer should stretch along the parent’s counter axis (auto layout).
    /// </summary>
    public bool? Stretch { get; set; }
    /// <summary>
    /// Determines whether a layer should stretch along the parent’s primary axis (auto layout).
    /// </summary>
    public bool? GrowStretch { get; set; }
    /// <summary>
    /// If wrapping is enabled.
    /// </summary>
    public bool? Wrap { get; set; }
    /// <summary>
    /// If auto distribute is enabled for wrapped content.
    /// </summary>
    public bool? WrapDistribute { get; set; }
    /// <summary>
    /// Color override.
    /// </summary>
    [SketchCompatibility]
    public ColorOverride? LegacyColor { get; set; }
    /// <summary>
    /// Text color override.
    /// </summary>
    [SketchCompatibility]
    public TextColorOverride? LegacyTextColor { get; set; }
    /// <summary>
    /// Text weight override.
    /// </summary>
    [SketchCompatibility]
    public TextWeightOverride? LegacyTextWeight { get; set; }
}