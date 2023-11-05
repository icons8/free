namespace Free.Schema;

/// <summary>
/// Embedded fonts stored in the document.
/// </summary>
public class Font
{
    /// <summary>
    /// Name of the font file in the fonts folder.
    /// </summary>
    public string Data { get; set; }
    /// <summary>
    /// Font name.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Font file name.
    /// </summary>
    public string FileName { get; set; }
    /// <summary>
    /// PostScript names of the font.
    /// </summary>
    public List<string> PostscriptNames { get; } = new();
}