namespace Free.Schema;
/// <summary>
/// A vector path determines the outline and form of a vector object. A path is made up of points and segments. 
/// </summary>
public class Path : Styled
{
    public override string _t => "PATH";
    /// <summary>
    /// Is shape edited in path editor.
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
}