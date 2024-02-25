namespace Free.Schema;

/// <summary>
/// Defines entities from shared libraries.
/// </summary>
public class Shared
{
    /// <summary>
    /// Color variables from an external library. 
    /// </summary>
    public List<ForeignColorVariable> ColorVariables { get; set; }
    /// <summary>
    /// Styles from an external library.
    /// </summary>
    public List<ForeignSharedStyle> Styles { get; set; }
    /// <summary>
    /// Components from an external library.
    /// </summary>
    public List<ForeignComponent> Components { get; set; }
}