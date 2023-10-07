namespace Free.Schema;

public enum PathFillType : byte
{
    /// <summary>Specifies that "inside" is computed by a non-zero sum of signed edge crossings.</summary>
    Winding,
    /// <summary>Specifies that "inside" is computed by an odd number of edge crossings.</summary>
    EvenOdd,
}