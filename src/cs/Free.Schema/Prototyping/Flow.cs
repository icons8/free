namespace Free.Schema;

public class Flow
{
    public FlowAnimationType Animation { get; set; } = FlowAnimationType.FromRight;

    public string Link { get; set; } = string.Empty;

    public bool MaintainScrollPos { get; set; }
}