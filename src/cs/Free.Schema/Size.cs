namespace Free.Schema;

public readonly struct Size
{
    public readonly float Width;
    public readonly float Height;

    public Size(float width, float height)
    {
        Width = width;
        Height = height;
    }
}