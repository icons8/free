namespace Free.Schema;

/// <summary>
/// A utility class to represent a rectangle.
/// </summary>
public readonly struct Rect
{
    /// <summary>
    /// The x coordinate of the top-left corner of the rectangle.
    /// </summary>
    public readonly float Left;
    
    /// <summary>
    /// The y coordinate of the top-left corner of the rectangle.
    /// </summary>
    public readonly float Top;
    
    /// <summary>
    /// The width of the rectangle.
    /// </summary>
    public readonly float Width;
    
    /// <summary>
    /// The height of the rectangle.
    /// </summary>
    public readonly float Height;

    public Rect(float left, float top, float width, float height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }
}