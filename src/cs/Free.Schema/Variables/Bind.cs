namespace Free.Schema;

/// <summary>
/// Bind of a variable into layer property.
/// </summary>
public class Bind
{
    /// <summary>
    /// Target field
    /// </summary>
    public BindField Field { get; set; } = BindField.Unknown;
    
    /// <summary>
    /// Id of variable with a value
    /// </summary>
    public Guid? VariableId { get; set; }
    
    /// <summary>
    /// Expression with a value
    /// </summary>
    public Expression? Expression { get; set; }
}