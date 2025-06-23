namespace Free.Schema;

/// <summary>
/// Collection of variables.
/// </summary>
public sealed class VariableCollection
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Name of variable collection.
    /// </summary>
    public string Name { get; set; } = "";
    
    /// <summary>
    /// List of variables inside collection.
    /// </summary>
    public List<Variable> Variables { get; } = new();
    
    /// <summary>
    /// List of variable mode names in this collection.
    /// </summary>
    public List<VariableMode> Modes { get; } = new();
    
    /// <summary>
    /// Version of collection.
    /// </summary>
    public int Version { get; set; } = 0;
}