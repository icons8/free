namespace Free.Schema;

/// <summary>
/// Side of a layer bound used as a measurement endpoint.
/// </summary>
[LunacySpecific]
public enum SideType : byte
{
    /// <summary>
    /// Left side.
    /// </summary>
    Left = 0,
    /// <summary>
    /// Right side.
    /// </summary>
    Right = 1,
    /// <summary>
    /// Top side.
    /// </summary>
    Top = 2,
    /// <summary>
    /// Bottom side.
    /// </summary>
    Bottom = 3,
}

/// <summary>
/// A persistent distance measurement between two layers.
/// </summary>
[LunacySpecific]
public class Measurement
{
    /// <summary>
    /// Identifier of the layer at the start of the measurement.
    /// </summary>
    public Guid Start { get; set; }
    /// <summary>
    /// Identifier of the layer at the end of the measurement.
    /// </summary>
    public Guid End { get; set; }
    /// <summary>
    /// Bound side used on the start layer.
    /// </summary>
    public SideType StartSide { get; set; }
    /// <summary>
    /// Bound side used on the end layer.
    /// </summary>
    public SideType EndSide { get; set; }
    /// <summary>
    /// Normalized position along the start bound.
    /// </summary>
    public float StartPos { get; set; }
    /// <summary>
    /// Optional custom measurement label.
    /// </summary>
    public string? Text { get; set; }
}
