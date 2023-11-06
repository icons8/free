namespace Free.Schema;
/// <summary>
/// A utility class to represent layer size.
/// </summary>
public readonly struct Size
{
    /// <summary>
    /// Layer width.
    /// </summary>
    public readonly float Width;
    /// <summary>
    /// Layer height.
    /// </summary>
    public readonly float Height;

    public Size(float width, float height)
    {
        Width = width;
        Height = height;
    }
}