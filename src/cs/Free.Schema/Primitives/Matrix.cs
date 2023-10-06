namespace Free.Schema;

public readonly struct Matrix
{
    public static readonly Matrix Identity = new(
        1f, 0f, 0f,
        0f, 1f, 0f);
    
    public readonly float ScaleX;
    public readonly float SkewX;
    public readonly float TransX;
    public readonly float SkewY;
    public readonly float ScaleY;
    public readonly float TransY;

    public Matrix(float scaleX, float skewX, float transX,
                  float skewY, float scaleY, float transY)
    {
        ScaleX = scaleX;
        SkewX = skewX;
        TransX = transX;

        SkewY = skewY;
        ScaleY = scaleY;
        TransY = transY;
    }
    
    public float Rotation => MathF.Atan2(SkewY, ScaleX);
    public float RotationDeg => MathF.Atan2(SkewY, ScaleX) * 180f / float.Pi;
}