namespace Free.Schema;

/// <summary>
/// Defines layout grid settings for a frame.
/// </summary>
public abstract class GridLayoutBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public string _t { get; }
    
    /// <summary>
    /// If layout grid is enabled.
    /// </summary>
    public bool Enabled { get; set; }
}