namespace Free.Schema;

/// <summary>
/// Embedded fonts stored in the document.
/// </summary>
public class Font
{
    /// <summary>
    /// File name of font file in fonts folder.
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
    /// PostScript names of font.
    /// </summary>
    public List<string> PostscriptNames { get; } = new();
}