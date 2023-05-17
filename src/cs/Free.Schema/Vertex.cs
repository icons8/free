using System.Runtime.CompilerServices;

namespace Free.Schema;

public readonly struct Vertex
{
    private readonly Half _radius;
    
    /// <summary>
    /// Base Point of a Vertex
    /// </summary>
    public readonly Point Point;

    /// <summary>
    /// First Control Point, Curve From
    /// </summary>
    public readonly Point From;

    /// <summary>
    /// Second Control Point, Curve To
    /// </summary>
    public readonly Point To;

    /// <summary>
    /// Corner Radius of a vertex point. It's stored in half because we don't need that much precision for corner radius
    /// </summary>
    public float Radius => (float)_radius;

    /// <summary>
    /// Vertex flags, contains: CurveMode, hasFrom, hasTo and CornerStyle
    /// </summary>
    public readonly VertexFlags Flags;

    public Vertex(Point point, CurveMode mode = CurveMode.Straight, float radius = 0)
    {
        Point = point;
        From = To = default;
        _radius = (Half)radius;
        Flags = ToFlags(mode);
    }

    public Vertex(Point point, Point from, Point to, CurveMode mode = CurveMode.Disconnected,
        float radius = 0f, bool hasFrom = true, bool hasTo = true, CornerStyle style = CornerStyle.Rounded)
    {
        Point = point;
        From = from;
        To = to;
        _radius = (Half)radius;
        Flags = ToFlags(mode) | ToFlags(style);
        if (hasFrom)
        {
            Flags |= VertexFlags.HasCurveFrom;
        }

        if (hasTo)
        {
            Flags |= VertexFlags.HasCurveTo;
        }
    }

    public Vertex(Point point, Point from, Point to, float radius, VertexFlags flags)
    {
        Point = point;
        From = from;
        To = to;
        _radius = (Half)radius;
        Flags = flags;
    }
    
    public CornerStyle Style
    {
        get
        {
            if (HasFlag(VertexFlags.Squared))
            {
                return CornerStyle.Squared;
            }

            if (HasFlag(VertexFlags.Angled))
            {
                return CornerStyle.Angled;
            }

            if (HasFlag(VertexFlags.RoundedInverted))
            {
                return CornerStyle.RoundedInverted;
            }

            return CornerStyle.Rounded;
        }
    }

    public CurveMode Mode
    {
        get
        {
            if (HasFlag(VertexFlags.Disconnected))
            {
                return CurveMode.Disconnected;
            }

            if (HasFlag(VertexFlags.Asymmetric))
            {
                return CurveMode.Asymmetric;
            }

            if (HasFlag(VertexFlags.Mirrored))
            {
                return CurveMode.Mirrored;
            }

            return CurveMode.Straight;
        }
    }
 
    public bool HasFrom => HasFlag(VertexFlags.HasCurveFrom);
    public bool HasTo => HasFlag(VertexFlags.HasCurveTo);
    public Point HandleIn => To - Point;
    public Point HandleOut => From - Point;
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool HasFlag(VertexFlags flag) => (Flags & flag) == flag;
    
    internal static VertexFlags ToFlags(CurveMode curveMode) => curveMode switch
    {
        CurveMode.Straight => VertexFlags.None,
        CurveMode.Mirrored => VertexFlags.Mirrored,
        CurveMode.Asymmetric => VertexFlags.Asymmetric,
        CurveMode.Disconnected => VertexFlags.Disconnected,
        _ => VertexFlags.None,
    };
    
    internal static VertexFlags ToFlags(CornerStyle cornerStyle) => cornerStyle switch
    {
        CornerStyle.RoundedInverted => VertexFlags.RoundedInverted,
        CornerStyle.Angled => VertexFlags.Angled,
        CornerStyle.Squared => VertexFlags.Squared,
        _ => VertexFlags.None,
    };
}