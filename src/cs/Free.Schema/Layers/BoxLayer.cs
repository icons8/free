namespace Free.Schema;

public abstract class BoxLayer : LayoutLayer
{
    public float[] CornerRadius { get; set; } = new float[4];
    public RadiusBehavior RadiusBehavior { get; set; } = RadiusBehavior.Rounded;
}