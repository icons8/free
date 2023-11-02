namespace Free.Schema;
/// <summary>
/// Defines the filling options for overlapping paths.
/// </summary>
public enum PathFillType : byte
{
    /// <summary>
    /// Applies the non-zero rule.
    /// </summary>
    Winding,
    /// <summary>
    /// Apllies the even-odd rule.
    /// </summary>
    EvenOdd,
}