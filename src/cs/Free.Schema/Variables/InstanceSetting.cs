namespace Free.Schema;

/// <summary>
/// Setting allows you to set a value for an instance property from a component.
/// </summary>
public class InstanceSetting : Argument
{
    /// <summary>
    /// Component property id. Required. Should be first.
    /// </summary>
    public Guid Id { get; set; }
}