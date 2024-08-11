namespace Free.Schema;

/// <summary>
/// Contains components, styles and variables from external library that is used in current document.
/// Every file in the shared folder is Shared Library.
/// </summary>
public class SharedLibrary
{
    /// <summary>
    /// URL to the Library. Can be http link or local path (local is not supported in Lunacy yet).
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
    /// Color variables from a shared library. 
    /// </summary>
    public List<ColorVariable> ColorVariables { get; set; }
    /// <summary>
    /// Styles from a shared library.
    /// </summary>
    public List<SharedStyle> Styles { get; set; }
    /// <summary>
    /// Components from a shared library.
    /// </summary>
    public List<Component> Components { get; set; }
}