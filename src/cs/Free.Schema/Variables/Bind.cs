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
    /// Bind Value
    /// </summary>
    public Argument Value { get; set; }
}