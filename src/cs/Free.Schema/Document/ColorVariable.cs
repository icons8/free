namespace Free.Schema;

/// <summary>
/// Color variables stored in the document.
/// </summary>
public class ColorVariable
{
    /// <summary>
    /// Variable ID.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Variable name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Color value of the variable.
    /// </summary>
    public Color Value { get; set; }
}