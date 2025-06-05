namespace Free.Schema;

/// <summary>
/// Style of fills. Can be set to borders and fills.
/// </summary>
public class FillStyle : StyleBase
{
    /// <summary>
    /// List of fills applied to a style.
    /// </summary>
    public List<Fill> Fills { get; } = new();
}