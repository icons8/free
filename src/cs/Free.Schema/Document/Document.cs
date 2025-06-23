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

    /// <summary>
    /// Сolor scheme the document uses.
    /// </summary>
    [SketchCompatibility]
    public ColorSpace ColorSpace { get; set; }

    /// <summary>
    /// Nudge Amount. X - small nudge. Y = large nudge.
    /// </summary>
    public Point Nudge { get; set; } = new Point(1, 10);
    /// <summary>
    /// If the document is imported from Figma.
    /// </summary>
    public bool FromFigma { get; set; }
    /// <summary>
    /// Index of the currently open page.
    /// </summary>
    public int CurrentPageIndex { get; set; }
    /// <summary>
    /// Embedded fonts stored in the document.
    /// </summary>
    public List<Font> Fonts { get; } = new();
    /// <summary>
    /// Variables stored in the document.
    /// </summary>
    public List<VariableCollection> Variables { get; } = new();
    /// <summary>
    /// Fill styles stored in the document.
    /// </summary>
    public List<FillStyle> FillStyles { get; } = new();
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
    public List<GridLayoutStyle> GridStyles { get; } = new();
    /// <summary>
    /// List of document pages.
    /// </summary>
    public List<Guid> Pages { get; } = new();
}