namespace Free.Schema;

/// <summary>
/// Style of fills. Can be set to borders and fills.
/// </summary>
public class ColorStyle : StyleBase
{
    /// <summary>
    /// If there is a single color fill - use this, otherwise use Fills field.
    /// </summary>
    public Color Fill { get; set; }
    /// <summary>
    /// List of fills applied to a style.
    /// </summary>
    public List<Fill> Fills { get; } = new();
}