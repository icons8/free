namespace Free.Schema;
/// <summary>
/// Defines layout grid settings for a frame.
/// </summary>
public interface IGridLayout
{
    /// <summary>
    /// If layout grid is enabled.
    /// </summary>
    bool Enabled { get; set; }
    string _t { get; }
}