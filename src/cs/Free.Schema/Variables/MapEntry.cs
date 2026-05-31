namespace Free.Schema;

/// <summary>
/// Map Entry. Has Key and Argument value.
/// </summary>
public class MapEntry : Argument
{
    /// <summary>
    /// Key of map entry. Required. Should be first.
    /// </summary>
    public Guid Key { get; set; }
}