namespace Free.Schema;

/// <summary>
/// Bind of a variable into layer property.
/// </summary>
public class Bind : Argument
{
    /// <summary>
    /// Target field. Required. Should be first.
    /// </summary>
    public BindField Field { get; set; } = BindField.Unknown;
}