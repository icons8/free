namespace Free.Schema;
/// <summary>
/// Defines overrides for components.
/// </summary>
public sealed class Override
{
    public Guid[] Target { get; set; } = Array.Empty<Guid>();
    
    public Guid? ComponentId { get; set; }
    public ExportOptions? Export { get; set; }
    public string? Image { get; set; }
    public string? Link { get; set; }
    public bool? Locked { get; set; }
    public bool? Hidden { get; set; }
    public bool? ClipContent { get; set; }
    public bool? LockAspect { get; set; }
    public float? Ratio { get; set; }
    public float? VertexCount { get; set; }
    public float? ArcAngle { get; set; }
    public float? ArcRatio { get; set; }
    public float? ArcStartAngle { get; set; }
    public float[]? CornerRadius { get; set; }
    public bool SmoothCorners { get; set; }
    
    public Guid? TextStyleId { get; set; }
    public Guid? LayerStyleId { get; set; }
    public Guid? StyleId { get; set; }
    public Color? Tint { get; set; }
    public Guid? TintId { get; set; }
    public List<Fill>? Fills { get; set; }
    public List<Border>? Borders { get; set; }
    public BorderOptions? BorderOptions { get; set; }
    public List<ShadowEffect>? Shadows { get; set; }
    public List<ShadowEffect>? InnerShadows { get; set; }
    public BlurEffect? Blur { get; set; }
    public ImageFilters? ImageFilters { get; set; }
    public float? Opacity { get; set; }
    public BlendMode? BlendMode { get; set; }
    public Arrowhead? StartArrowhead { get; set; }
    public Arrowhead? EndArrowhead { get; set; }
    
    //Text
    public string? Text { get; set; }
    public TextStyle? TextStyle { get; set; }
    public List<InlineStyle>? Inlines { get; set; }
    public TextBehavior? TextBehavior { get; set; }
    public Size? Size { get; set; }

    // Layout
    public LayoutOrientation? Orientation { get; set; }
    public float? Spacing { get; set; }
    public float? WrapSpacing { get; set; }
    public float? MinWidth { get; set; }
    public float? MinHeight { get; set; }
    public float? MaxWidth { get; set; }
    public float? MaxHeight { get; set; }
    public Thickness? Padding { get; set; }
    public HorizontalAlignment? Align { get; set; }
    public VerticalAlignment? VAlign { get; set; }
    public SizingMode? Sizing { get; set; }
    public SizingMode? VSizing { get; set; }
    public bool? TextBaseline { get; set; }
    public bool? StrokesIncluded { get; set; }
    public bool? ReverseZIndex { get; set; }
    public bool? Stretch { get; set; }
    public bool? GrowStretch { get; set; }
    public bool? Wrap { get; set; }
    public bool? WrapDistribute { get; set; }
    
    [SketchCompatibility]
    public ColorOverride? LegacyColor { get; set; }
    [SketchCompatibility]
    public TextColorOverride? LegacyTextColor { get; set; }
    [SketchCompatibility]
    public TextWeightOverride? LegacyTextWeight { get; set; }
}