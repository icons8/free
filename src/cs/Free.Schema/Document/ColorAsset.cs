namespace Free.Schema;

/// <summary>
/// Colors stored in the document (color picker > dropdown list (global) > document).
/// </summary>
public class ColorAsset
{
    /// <summary>
    /// Unique color asset ID.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Color asset name.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Color value.
    /// </summary>
    public Color Color { get; set; }
}