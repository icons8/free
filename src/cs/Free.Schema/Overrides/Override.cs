namespace Free.Schema;

public abstract class Override
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
    public float? MinWidth { get; set; }
    public float? MinHeight { get; set; }
    public float? MaxWidth { get; set; }
    public float? MaxHeight { get; set; }
    public float? Ratio { get; set; }
    public float? VertexCount { get; set; }
    public float? ArcAngle { get; set; }
    public float? ArcRatio { get; set; }
    public float? ArcStartAngle { get; set; }
    public float[]? CornerRadius { get; set; }
    public RadiusBehavior? RadiusBehavior { get; set; }
    
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
    public BlendingMode? BlendMode { get; set; }
    public Arrowhead? StartArrowhead { get; set; }
    public Arrowhead? EndArrowhead { get; set; }
    
    //Text
    public string? Text { get; set; }
    public TextStyle? TextStyle { get; set; }
    public List<InlineStyle>? Inlines { get; set; }
    public TextBehavior? TextBehavior { get; set; }
    public Size? TextSize { get; set; }

    // Layout
    public LayoutOverride? Layout { get; set; }
    
    //sketch legacy support
    public ColorOverride? LegacyColor { get; set; }
    public TextColorOverride? LegacyTextColor { get; set; }
    public TextWeightOverride? LegacyTextWeight { get; set; }
}