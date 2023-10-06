namespace Free.Schema;

public class Layer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool NameIsFixed { get; set; }
    public BoolOp BooleanOperation { get; set; }
    public bool IsPositionFixed { get; set; }
    public bool IsLocked { get; set; }
    public bool IsVisible { get; set; }
    public bool IsTemplate { get; set; }
    public LayerExpandedType LayerExpandedType { get; set; }
    public ResizingConstraintType Constraint { get; set; }
    public bool LockAspect { get; set; }
    public Matrix Transform { get; set; } = Matrix.Identity;
    public Size Size { get; set; } = new(100, 100);
    public bool IsMask { get; set; }
    public bool IgnoreMask { get; set; }
    public FlowConnection? FlowConnection { get; set; }
    public ExportOptions ExportOptions { get; } = new();
    public INodeInfo? Info { get; set; }
    public Dictionary<string, string>? UserInfo { get; set; }
    public float MinWidth { get; set; }
    public float MinHeight { get; set; }
    public float MaxWidth { get; set; }
    public float MaxHeight { get; set; }
    public bool IsLayoutStretch { get; set; }
    public bool IsLayoutGrowStretch { get; set; }
    public bool IsLayoutPositionAbsolute { get; set; }
}