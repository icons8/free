namespace Free.Schema;

/// <summary>
/// The document's .json structure.
/// </summary>
public class Document
{
    /// <summary>
    /// Unique document ID.
    /// </summary>
    public Guid Id { get; set; }
    public ColorSpace ColorSpace { get; set; }
    /// <summary>
    /// If the document is imported from Figma.
    /// </summary>
    public bool FromFigma { get; set; }
    public int CurrentPageIndex { get; set; }
    /// <summary>
    /// Images stored in the document.
    /// </summary>
    public List<string> Images { get; } = new();
    /// <summary>
    /// Colors stored in the document (color picker > dropdown list (global) > document).
    /// </summary>
    public List<ColorAsset> Colors { get; } = new();
    /// <summary>
    /// Gradients stored in the document (color picker > dropdown list (global) > document).
    /// </summary>
    public List<GradientAsset> Gradients { get; } = new();
    /// <summary>
    /// Embedded fonts stored in the document.
    /// </summary>
    public List<Font> Fonts { get; } = new();
    /// <summary>
    /// Color variables stored in the document.
    /// </summary>
    public List<ColorVariable> ColorVariables { get; } = new();
    /// <summary>
    /// Layer styles stored in the document.
    /// </summary>
    public List<SharedStyle> LayerStyles { get; } = new();
    /// <summary>
    /// Text styles stored in the document.
    /// </summary>    
    public List<SharedStyle> TextStyles { get; } = new();
    /// <summary>
    /// List of document pages.
    /// </summary>
    public List<Guid> Pages { get; } = new();
}