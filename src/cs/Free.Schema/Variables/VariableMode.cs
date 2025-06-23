namespace Free.Schema;

/// <summary>
/// Mode of variables. Used to switch all variable values inside specific collection.
/// </summary>
public sealed class VariableMode
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Name of mode.
    /// </summary>
    public string Name { get; set; } = "";
}