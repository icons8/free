namespace Free.Schema;

/// <summary>
/// A layer is any ungrouped element available on the canvas.
/// </summary>

public abstract class Layer
{
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
    /// ??????
    /// </summary>
    public bool NameIsFixed { get; set; }
    /// <summary>
    /// Defines the boolean operation applied to the layer.
    /// </summary>
    public BoolOp BooleanOp { get; set; }
    /// <summary>
    /// ???????
    /// </summary>
    public bool Fixed { get; set; }
    /// <summary>
    /// Defines whether the layer is locked.
    /// </summary>
    public bool Locked { get; set; }
    /// <summary>
    /// Defines whether the layer is hidden.
    /// </summary>
    public bool Hidden { get; set; }
    /// <summary>
    /// ???????
    /// </summary>
    public bool IsTemplate { get; set; }
    /// <summary>
    /// Defines whether the layer is expanded in Layer List.??????? But that's a layer, not a group???
    /// </summary>
    public bool Expand { get; set; }
    /// <summary>
    /// Defines export settings of the layer.
    /// </summary>
    public ExportOptions Export { get; } = new();
    
    /// <summary>
    /// Defines constraint settings of the layer. Possible values: LEFT, TOP, RIGHT, BOTTOM, FIXW, FIXH, ALL
    /// </summary>
    public string[] Constraints { get; set; }
    /// <summary>
    /// ???????????
    /// </summary>
    public Matrix Transform { get; set; } = Matrix.Identity;
    /// <summary>
    /// Defines the layer size.
    /// </summary>
    public Size Size { get; set; } = new(100, 100);
    /// <summary>
    /// Defines whether the layer's aspect ratio should be remain unchanged upon resizing.
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
    /// If the Fix position on scroll option is enabled (prototyping).
    /// </summary>
    public bool KeepScroll { get; set; }
    /// <summary>
    /// Defines the animation type (prototyping).
    /// </summary>
    public AnimationType Animation { get; set; } = AnimationType.FromRight;
    /// <summary>
    /// Defines the target frame (prototyping).
    /// </summary>
    public string Link { get; set; } = string.Empty;
    /// <summary>
    /// Define the minimum la
    /// </summary>
    public float MinWidth { get; set; }
    public float MinHeight { get; set; }
    public float MaxWidth { get; set; }
    public float MaxHeight { get; set; }
    public bool LayoutStretch { get; set; }
    public bool LayoutGrowStretch { get; set; }
    public bool LayoutFixPos { get; set; }
    
    [LunacySpecific]
    public string? PhotoId { get; set; }
    [LunacySpecific]
    public string? IllustrationId { get; set; }
    [LunacySpecific]
    public string? IconId { get; set; }
    [LunacySpecific]
    public string? AvatarId { get; set; }
    [LunacySpecific]
    public DataInfo? Data { get; set; }
    [LunacySpecific]
    public bool Upscaled { get; set; }
    [LunacySpecific]
    public BackgroundRemovalState BackgroundRemove { get; set; }
}