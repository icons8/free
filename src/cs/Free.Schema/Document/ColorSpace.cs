namespace Free.Schema;

/// <summary>
/// Document's color space (color scheme the document uses).
/// </summary>
[SketchCompatibility]
public enum ColorSpace : byte
{
    Unmanaged = 0,
    sRGB = 1,
    P3 = 2,
}