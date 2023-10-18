namespace Free.Schema;

/// <summary>
/// document.json structure
/// </summary>
public class Document
{
    public Guid Id { get; set; }
    public ColorSpace ColorSpace { get; set; }
    /// <summary>
    /// is imported from Figma
    /// </summary>
    public bool FromFigma { get; set; }
    public int CurrentPageIndex { get; set; }
    /// <summary>
    /// Images stored in the document (colorpicker>dropdown (global)> document)
    /// </summary>
    public List<string> Images { get; } = new();
    /// <summary>
    /// Colors stored in the document (colorpicker>dropdown (global)> document)
    /// </summary>
    public List<ColorAsset> Colors { get; } = new();
    /// <summary>
    /// Gradients stored in the document (colorpicker>dropdown (global)> document)
    /// </summary>
    public List<GradientAsset> Gradients { get; } = new();
    /// <summary>
    /// Shared fonts are stored in the document 
    /// </summary>
    public List<Font> Fonts { get; } = new();
    public List<ColorVariable> ColorVariables { get; } = new();
    public List<SharedStyle> LayerStyles { get; } = new();
    public List<SharedStyle> TextStyles { get; } = new();
    public List<Guid> Pages { get; } = new();
}