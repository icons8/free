namespace Free.Schema;

/// <summary>
/// Shared fonts stored in the document. ??? embeded??? 
/// </summary>
public class Font
{
    /// <summary>
    /// ?????????
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
    /// ??????
    /// </summary>
    public List<string> PostscriptNames { get; } = new();
}