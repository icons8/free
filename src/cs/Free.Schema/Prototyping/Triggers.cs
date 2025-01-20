namespace Free.Schema;

public abstract class FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public abstract string _t { get; }
}

public sealed class ClickTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "CLICK";
}

public sealed class DragTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "DRAG";
}
public sealed class HoverTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "HOVER";
}
public sealed class HoldTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "HOLD";
}
public sealed class KeyPressTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "KEY_DOWN";
    public string? Shortcut { get; }
    public int Delay { get; set; }
}

public sealed class MouseEnterTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "ENTER";
    public int Delay { get; set; }
}

public sealed class MouseLeaveTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "LEAVE";
    public int Delay { get; set; }
}

public sealed class MouseDownTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "MOUSE_DOWN";
    public int Delay { get; set; }
}

public sealed class MouseUpTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "MOUSE_UP";
    public int Delay { get; set; }
}

public sealed class AfterDelayTrigger : FlowTrigger
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "DELAY";
    public int Delay { get; set; }
}