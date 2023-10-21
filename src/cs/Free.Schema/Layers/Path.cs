namespace Free.Schema;

public class Path : Styled
{
    public override string _t => "PATH";
    /// <summary>
    /// ???????
    /// </summary>
    public bool Edited { get; set; }
    /// <summary>
    /// Indicates whether the path is open.
    /// </summary>
    public bool Open { get; set; }
    /// <summary>
    /// List of path's points.
    /// </summary>
    public List<Vertex> Points { get; } = new();
    /// <summary>
    /// Why is it here???? Paths have corner radius, but don't have the smooth corner option???????
    /// </summary>
    public bool SmoothCorners { get; set; }
}