namespace Free.Schema;

/// <summary>
/// States Property
/// </summary>
public class StateProperty
{
    /// <summary>
    /// Name of the property
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// String values of a property
    /// </summary>
    public List<string> Values { get; set; } = new();
}