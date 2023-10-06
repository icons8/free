namespace Free.Schema;

public readonly struct Thickness
{
    public readonly float Left;
    public readonly float Top;
    public readonly float Right;
    public readonly float Bottom;

    public Thickness(float uniformLength)
    {
        Left = Top = Right = Bottom = uniformLength;
        IsUniform = true;
    }

    public Thickness(float horizontal, float vertical)
    {
        Left = Right = horizontal;
        Top = Bottom = vertical;
        IsUniform = horizontal.Equals(vertical);
    }

    public Thickness(float left, float top, float right, float bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
        IsUniform = Left.Equals(Right) && Top.Equals(Bottom) && Right.Equals(Bottom);
    }

    public float Single => IsUniform ? Left : 1f;

    /// <summary>
    /// Gets a value indicating whether all sides are equal.
    /// </summary>
    public bool IsUniform { get; }
}