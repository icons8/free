namespace Free.Schema;

/// <summary>
/// Сolor scheme the document uses.
/// </summary>
[SketchCompatibility]
public enum ColorSpace : byte
{
    Unmanaged = 0,
    sRGB = 1,
    P3 = 2,
}