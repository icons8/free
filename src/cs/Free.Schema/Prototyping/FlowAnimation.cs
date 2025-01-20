namespace Free.Schema;

public class FlowAnimation
{
    public bool Enabled { get; set; }
    public FlowAnimationType Type { get; set; }
    public FlowAnimationEffect Effect { get; set; }
    public FlowAnimationDirection Direction { get; set; }
    public int Duration { get; set; }
    public float[] Curve { get; set; }
}