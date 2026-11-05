namespace Free.Schema;

/// <summary>
/// A handoff annotation attached to a layer.
/// </summary>
[LunacySpecific]
public class LayerAnnotation
{
    /// <summary>
    /// Required annotation identifier, unique on its owning layer.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Plain-text note displayed to the reader.
    /// </summary>
    public string Text { get; set; } = "";

    /// <summary>
    /// Optional source markup preserved from an imported annotation.
    /// The text field supplies the plain-text representation.
    /// </summary>
    public string? RichText { get; set; }

    /// <summary>
    /// Optional identifier in the document's annotation category catalog.
    /// A missing category reference is displayed as uncategorized.
    /// </summary>
    public Guid? CategoryId { get; set; }

    /// <summary>
    /// Ordered property keys such as width, height, or opacity. Values are resolved from the owning layer.
    /// Unrecognized property keys can be preserved for interoperability.
    /// </summary>
    public List<string> PinnedProperties { get; } = new();

    /// <summary>
    /// Ordered custom text fields.
    /// </summary>
    public List<AnnotationField> CustomFields { get; } = new();
}

/// <summary>
/// A custom field on a handoff annotation.
/// </summary>
[LunacySpecific]
public class AnnotationField
{
    /// <summary>
    /// Name of the field.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Text value of the field.
    /// </summary>
    public string Value { get; set; } = "";
}
