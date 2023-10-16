namespace Free.Schema;

public enum BaselinePosition : sbyte
{
    Normal = 0,
    /// <summary>
    /// small letter on top, like a^2
    /// </summary>
    Superscript = 1,
    /// <summary>
    /// small letter on bottom
    /// </summary>
    Subscript = -1
}