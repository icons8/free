namespace Free.Schema;

/// <summary>
/// A layer group is two or more layers unified into a single entity that can be manipulated, organized, and treated as a single layer.
/// </summary>

public class Group : Styled
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "GROUP";


    /// <summary>
    /// When enabled, users can select group items without first selecting the group.
    /// </summary>
    public bool SkipSelect { get; set; }
    /// <summary>
    /// Serves for constraints compatibility with Sketch. If the file is imported from the Sketch format, the parameter should be set to false to handle constraints properly.
    /// </summary>
    [SketchCompatibility]
    public bool SkipConstraints { get; set; }


    /// <summary>
    /// List of layers within the group.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}