namespace Free.Schema;

/// <summary>
/// Style of fills. Can be set to borders and fills.
/// </summary>
public class ColorStyle : StyleBase
{
    /// <summary>
    /// List of fills applied to a style.
    /// </summary>
    public List<Fill> Fills { get; } = new();
}