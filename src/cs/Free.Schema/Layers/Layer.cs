namespace Free.Schema;

public abstract class Layer
{
    public abstract string _t { get; }
    
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool NameIsFixed { get; set; }
    public BoolOp BooleanOp { get; set; }
    public bool Fixed { get; set; }
    public bool Locked { get; set; }
    public bool Hidden { get; set; }
    public bool IsTemplate { get; set; }
    public ExpandedType Expand { get; set; }
    public ExportOptions Export { get; } = new();
    
    /// <summary>
    /// Possible Flag's values: LEFT, TOP, RIGHT, BOTTOM, FIXW, FIXH, ALL
    /// </summary>
    public string[] Constraints { get; set; }
    public Matrix Transform { get; set; } = Matrix.Identity;
    public Size Size { get; set; } = new(100, 100);
    public bool LockAspect { get; set; }
    
    public bool Mask { get; set; }
    public bool BreakMask { get; set; }
    
    public bool KeepScroll { get; set; }
    public FlowAnimationType Animation { get; set; } = FlowAnimationType.FromRight;
    public string Link { get; set; } = string.Empty;
    
    public float MinWidth { get; set; }
    public float MinHeight { get; set; }
    public float MaxWidth { get; set; }
    public float MaxHeight { get; set; }
    public bool LayoutStretch { get; set; }
    public bool LayoutGrowStretch { get; set; }
    public bool LayoutFixPos { get; set; }
    
    public PhotoInfo? Photo { get; set; }
    public IllustrationInfo? Illustration { get; set; }
    public IconInfo? Icon { get; set; }
    public DataInfo? Data { get; set; }
    public bool Upscaled { get; set; }
    public BackgroundRemovalState BackgroundRemove { get; set; }
}