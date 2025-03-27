using System.Text;

namespace Free.Schema;

/// <summary>
/// A utility class to represent a vertex.
/// </summary>
public readonly struct Vertex
{
    private readonly Half _radius;
    
    /// <summary>
    /// Base point of a vertex
    /// </summary>
    public readonly Point Point;

    /// <summary>
    /// First control point, curve from.
    /// </summary>
    public readonly Point From;

    /// <summary>
    /// Second control point, curve to.
    /// </summary>
    public readonly Point To;

    /// <summary>
    /// Corner radius of a vertex point. It's stored in half because we don't need that much precision for corner radius.
    /// </summary>
    public float Radius => (float)_radius;

    /// <summary>
    /// Mode of vertex.
    /// </summary>
    public readonly CurveMode Mode;

    public Vertex(Point point, CurveMode mode = CurveMode.Straight, float radius = 0)
    {
        Point = From = To = point;
        _radius = (Half)radius;
        Mode = mode;
    }
    
    public Vertex(Point point, Point from, Point to, CurveMode mode = CurveMode.Disconnected,
        float radius = 0f, bool hasFrom = true, bool hasTo = true)
    {
        Point = point;
        From = from;
        To = to;
        _radius = (Half)radius;
        Mode = mode;

        if (Mode == CurveMode.Straight && (hasTo || hasFrom))
        {
            Mode = CurveMode.Disconnected;
        }
        if (Mode == CurveMode.Disconnected && (!hasFrom || !hasTo))
        {
            Mode = hasFrom ? CurveMode.OnlyFrom : CurveMode.OnlyTo;
        }
    }
    
    public Vertex(Point point, Point from, Point to, float radius, CurveMode mode)
    {
        Point = point;
        From = from;
        To = to;
        _radius = (Half)radius;
        Mode = mode;
    }
    
 
    public bool HasFrom => Mode is CurveMode.Mirrored or CurveMode.Disconnected or CurveMode.Asymmetric or CurveMode.OnlyFrom;
    public bool HasTo => Mode is CurveMode.Mirrored or CurveMode.Disconnected or CurveMode.Asymmetric or CurveMode.OnlyTo;
    public bool HasCornerRadius => Radius > 0 && Mode == CurveMode.Straight;
    public Point HandleIn => To - Point;
    public Point HandleOut => From - Point;
    
    public override string ToString()
    {
        var sb = new StringBuilder(Point.ToString()).Append(' ').Append(Mode);

        if (HasFrom)
        {
            sb.Append(", From ").Append(From);
        }

        if (HasTo)
        {
            sb.Append(", To ").Append(To);
        }

        return sb.Append(", r=").Append(Radius).ToString();
    }
}