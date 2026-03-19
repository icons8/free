namespace Free.Schema;

/// <summary>
/// Bind of component property of a states layer to the state name of component.
/// </summary>
public class StateBind
{
    /// <summary>
    /// Component Property Id
    /// </summary>
    public Guid PropertyId { get; set; }

    /// <summary>
    /// State Name
    /// </summary>
    public string Name { get; set; } = "";
    
    /// <summary>
    /// Id of string variable with a value
    /// </summary>
    public Guid? VariableId { get; set; }
}