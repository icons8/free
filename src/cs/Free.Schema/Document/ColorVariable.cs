namespace Free.Schema;

/// <summary>
/// Color variables stored in the document.
/// </summary>
public class ColorVariable
{
    /// <summary>
    /// Unique color variable ID.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Color variable name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Color value of the variable.
    /// </summary>
    public Color Value { get; set; }
}