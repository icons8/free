namespace Free.Schema;
/// <summary>
/// Defines text position against the baseline.
/// </summary>
public enum BaselinePosition : sbyte
{
    /// <summary>
    /// Text is lowered below the baseline.
    /// </summary>
    Subscript = -1,
    /// <summary>
    /// Text is aligned with the baseline.
    /// </summary>
    Normal = 0,
    /// <summary>
    /// Text is raised above the baseline.
    /// </summary>
    Superscript = 1
}