namespace Free.Schema;

/// <summary>
/// Gradients stored in the document (color picker > dropdown list (global) > document).
/// </summary>
public class GradientAsset
{
    /// <summary>
    /// Unique asset id.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Asset name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Values of gradients.
    /// </summary>
    public Gradient Value { get; set; } = new();
}