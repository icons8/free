namespace Free.Schema;

/// <summary>
/// Colors stored in the document (color picker > dropdown list (global) > document).
/// </summary>
public class ColorAsset
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Color Color { get; set; }
}