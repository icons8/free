namespace Free.Schema;
/// <summary>
/// Defines the type of a text list.
/// </summary>
public enum ListMarkerType : byte
{
    /// <summary>
    /// List without markers.
    /// </summary>
    None,
    /// <summary>
    /// Bulleted list.
    /// </summary>
    Bullet,
    /// <summary>
    /// Numbered list.
    /// </summary>
    Numbered
}