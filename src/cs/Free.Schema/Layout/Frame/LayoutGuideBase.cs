namespace Free.Schema;

/// <summary>
/// Defines layout guide settings for a frame.
/// </summary>
public abstract class LayoutGuideBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public string _t { get; }
    
    /// <summary>
    /// If layout guide is enabled.
    /// </summary>
    public bool Enabled { get; set; }
}