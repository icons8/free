namespace Free.Schema;

/// <summary>
/// Set of a states of the component.
/// </summary>
public class States : Frame
{
    public override string _t => "STATES";

    /// <summary>
    /// Component properties of states.
    /// </summary>
    public List<ComponentPropertyBase> Properties { get; } = new();
}