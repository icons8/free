namespace Free.Schema;

/// <summary>
/// A transformation matrix is standard way in computer graphics to represent translation and rotation.
/// These are the top two rows of a 3x3 matrix. The bottom row of the matrix is assumed to be [0, 0, 1].
/// This is known as an affine transform and is enough to represent translation, rotation, and skew.
/// The identity transform is [1, 0, 0,   0, 1, 0].
/// A translation matrix will typically look like: [1, 0, tx,   0, 1, ty]
/// and a rotation matrix will typically look like: [cos(angle), -sin(angle), 0, sin(angle), cos(angle), 0]
/// </summary>
public readonly struct Matrix
{
    public static readonly Matrix Identity = new(
        1f, 0f, 0f,
        0f, 1f, 0f);
    
    /// <summary>
    /// Scale by x-coord. Usually should be 1.
    /// If it's -1 - the layer is flipped horizontally.
    /// If it's some random number - it's a cos(angle).
    /// </summary>
    public readonly float ScaleX;
    
    /// <summary>
    /// Skew by x-coord. Usually should be 0.
    /// If it's some random number - it's a -sin(angle).
    /// </summary>
    public readonly float SkewX;
    
    /// <summary>
    /// Translation by x-coord.
    /// </summary>
    public readonly float TransX;
    
    /// <summary>
    /// Skew by y-coord. Usually should be 0.
    /// If it's some random number - it's a sin(angle).
    /// </summary>
    public readonly float SkewY;
    
    /// <summary>
    /// Scale by y-coord. Usually should be 1.
    /// If it's -1 - the layer is flipped vertically.
    /// If it's some random number - it's a cos(angle).
    /// </summary>
    public readonly float ScaleY;
    
    /// <summary>
    /// Translation by y-coord.
    /// </summary>
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