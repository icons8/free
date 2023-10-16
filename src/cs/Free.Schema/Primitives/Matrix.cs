namespace Free.Schema;

/// <summary>
/// A transformation matrix is standard way in computer graphics to represent translation and rotation.
/// These are the top two rows of a 3x3 matrix. The bottom row of the matrix is assumed to be [0, 0, 1].
/// This is known as an affine transform and is enough to represent translation, rotation, and skew.
/// The identity transform is [1, 0, 0,   0, 1, 0].
/// A translation matrix will typically look like: [1, 0, tx,   0, 1, ty]
/// and a rotation matrix will typically look like: [cos(angle), -sin(angle), 0,   sin(angle), cos(angle), 0]
/// If Matrix contains only translation it will be printed like point [0,5]
/// </summary>
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