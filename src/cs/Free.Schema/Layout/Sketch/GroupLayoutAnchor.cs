namespace Free.Schema;

/// <summary>
/// Layout alignment on axis. For vertical it's: left, center or right. For horizontal: top, middle or bottom.
/// </summary>
[SketchCompatibility]
public enum GroupLayoutAnchor : byte
{
    Begin = 0, //left to right, top to bottom
    Middle = 1, //center, middle
    End = 2, //right to left, bottom to top
}