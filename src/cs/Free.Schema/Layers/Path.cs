namespace Free.Schema;
/// <summary>
/// A vector path determines the outline and form of a vector object. A path is made up of points and segments. 
/// </summary>
public class Path : Styled
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "PATH";
    /// <summary>
    /// If the shape is edited in the path editor.
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