namespace Free.Schema;

/// <summary>
/// Set of a states of the component.
/// </summary>
public class States : Frame
{
    public override string _t => "STATES";

    /// <summary>
    /// Properties of states
    /// </summary>
    public List<StateProperty> Properties { get; set; } = new();
}