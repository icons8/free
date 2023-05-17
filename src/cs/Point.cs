namespace Free;

/// <summary>A utility class to represent a point.</summary>
public readonly struct Point
{
    /// <summary>The x coordinate of the point.</summary>
    public readonly float X;
    
    /// <summary>The y coordinate of the point.</summary>
    public readonly float Y;

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}