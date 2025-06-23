namespace Free.Schema;

/// <summary>
/// Contains components, styles and variables from external library that is used in current document.
/// Every file in the shared folder is Shared Library.
/// </summary>
public class SharedLibrary
{
    /// <summary>
    /// URL to the Library. Can be http link or local path (local is not supported in Lunacy yet).
    /// </summary>
    public string? Url { get; set; }
    /// <summary>
    /// Unique library document identifier.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Library name.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Variables from a shared library. 
    /// </summary>
    public List<VariableCollection> Variables { get; } = new();
    /// <summary>
    /// Fill styles stored in the document.
    /// </summary>
    public List<ColorStyle> FillStyles { get; } = new();
    /// <summary>
    /// Effect styles stored in the document.
    /// </summary>
    public List<EffectStyle> EffectStyles { get; } = new();
    /// <summary>
    /// Text styles stored in the document.
    /// </summary>
    public List<TextStyle> TextStyles { get; } = new();
    /// <summary>
    /// Grid layout styles stored in the document.
    /// </summary>
    public List<GuideStyle> GridStyles { get; } = new();
    /// <summary>
    /// Components from a shared library.
    /// </summary>
    public List<Component> Components { get; set; }
}