namespace Free.Schema;

public sealed class BorderOptions
{
    public bool IsEnabled { get; set; }

    public LineCap LineCap { get; set; } = LineCap.Butt;
    public LineJoin LineJoin { get; set; } = LineJoin.Miter;

    public float[] Dash { get; set; }
}