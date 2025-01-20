namespace Free.Schema;

/// <summary>
/// A layer is any ungrouped element available on the canvas.
/// </summary>
public abstract class Layer
{
    /// <summary>
    /// Object type
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
    /// Name can be auto-generated or user-specified. User-specified fixed names will not be renamed after some operations.
    /// </summary>
    public bool NameIsFixed { get; set; }
    /// <summary>
    /// Defines the boolean operation applied to the layer.
    /// </summary>
    public BoolOp BooleanOp { get; set; }
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
    public List<ExportOption> Export { get; set; } = new();

    /// <summary>
    /// Defines constraint settings of the layer. String with chars where every char means a flag:
    /// L - left, T - top, R - right, B - bottom, W - fix width, H - fix height.
    /// </summary>
    public string Constraints { get; set; } = "LTWH";
    /// <summary>
    /// Position, rotation and flips of an object, stored in a single 3x2 matrix.
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
    /// Defines flows (prototyping).
    /// </summary>
    public List<Flow> Flows { get; set; } = new();
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
    /// Determines if the layer should stretch along the parent’s counter axis (auto layout).
    /// </summary>
    public bool LayoutStretch { get; set; }
    /// <summary>
    /// Determines whether a layer should stretch along the parent’s primary axis (auto layout).
    /// </summary>
    public bool LayoutGrowStretch { get; set; }
    /// <summary>
    /// Enables absolute position for the layer (auto layout).
    /// </summary>
    public bool LayoutFixPos { get; set; }
    
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
}