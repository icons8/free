namespace Free.Schema;

/// <summary>
/// A named category for handoff annotations within one document.
/// </summary>
[LunacySpecific]
public class AnnotationCategory
{
    /// <summary>
    /// Required category identifier, unique within the document.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Category label displayed to the reader.
    /// </summary>
    public string Label { get; set; } = "";

    /// <summary>
    /// Category accent color.
    /// </summary>
    public Color Color { get; set; } = new(0, 0, 0);

    /// <summary>
    /// Optional preset identifier, such as DEVELOPMENT, INTERACTION, ACCESSIBILITY, or CONTENT.
    /// </summary>
    public string? Preset { get; set; }
}
