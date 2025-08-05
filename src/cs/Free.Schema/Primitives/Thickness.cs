namespace Free.Schema;

/// <summary>
/// Thickness struct. Used for Border thickness and Padding values
/// </summary>
public readonly struct Thickness
{
    /// <summary>
    /// Left thickness.
    /// </summary>
    public readonly float Left;
    /// <summary>
    /// Top thickness.
    /// </summary>
    public readonly float Top;
    /// <summary>
    /// Right thickness.
    /// </summary>
    public readonly float Right;
    /// <summary>
    /// Bottom thickness.
    /// </summary>
    public readonly float Bottom;

    public Thickness(float uniformLength)
    {
        Left = Top = Right = Bottom = uniformLength;
    }

    public Thickness(float horizontal, float vertical)
    {
        Left = Right = horizontal;
        Top = Bottom = vertical;
    }

    public Thickness(float left, float top, float right, float bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
    }
}