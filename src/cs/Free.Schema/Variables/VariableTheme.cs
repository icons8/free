namespace Free.Schema;

/// <summary>
/// Theme of variables. Used to switch all variable values inside specific collection.
/// </summary>
public sealed class VariableTheme
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Name of the theme.
    /// </summary>
    public string Name { get; set; } = "";
}