namespace Free.Schema;

/// <summary>
/// Defines entities from external libraries.
/// </summary>
public class Foreign
{
    /// <summary>
    /// Color variables from an external library. 
    /// </summary>
    public List<ForeignColorVariable> ColorVariables { get; set; }
    /// <summary>
    /// Layer styles from an external library.
    /// </summary>
    public List<ForeignSharedStyle> LayerStyles { get; set; }
    /// <summary>
    /// Text styles from an external library.
    /// </summary>
    public List<ForeignSharedStyle> TextStyles { get; set; }
    /// <summary>
    /// Components from an external library.
    /// </summary>
    public List<ForeignComponent> Components { get; set; }
}