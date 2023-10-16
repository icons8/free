namespace Free.Schema;

/// <summary>
/// A layer group is two and more layers unified into a single entity that can be manipulated, organized, and treated as a single layer.
/// </summary>

public class Group : Styled
{
    public override string _t => "GROUP";


    /// <summary>
    /// When enabled, users can select group items without first selecting the group.
    /// </summary>
    public bool SkipSelect { get; set; }
    public bool SkipConstraints { get; set; }
    public IGroupLayout? GroupLayout { get; set; }


    /// <summary>
    /// List of layers within the group.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}