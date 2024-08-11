namespace Free.Schema;

/// <summary>
/// Contains Assets from External Library
/// </summary>
public class SharedLibrary
{
    /// <summary>
    /// URL to the Server of Library.
    /// </summary>
    public string? Url { get; set; }
    /// <summary>
    /// Unique library document identifier.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Library name.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Color variables from an external library. 
    /// </summary>
    public List<ColorVariable> ColorVariables { get; set; }
    /// <summary>
    /// Styles from an external library.
    /// </summary>
    public List<SharedStyle> Styles { get; set; }
    /// <summary>
    /// Components from an external library.
    /// </summary>
    public List<Component> Components { get; set; }
}