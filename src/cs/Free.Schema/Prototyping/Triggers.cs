namespace Free.Schema;

/// <summary>
/// Base object of prototyping trigger.
/// </summary>
public abstract class FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public abstract string _t { get; }
}

/// <summary>
/// Mouse click.
/// </summary>
public sealed class ClickTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "CLICK";
}

/// <summary>
/// Mouse drag.
/// </summary>
public sealed class DragTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "DRAG";
}

/// <summary>
/// Mouse hover - only while mouse pointer is over layer.
/// </summary>
public sealed class HoverTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "HOVER";
}

/// <summary>
/// Mouse hold - only while you press and hold a mouse button.
/// </summary>
public sealed class HoldTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "HOLD";
}

/// <summary>
/// Key down.
/// </summary>
public sealed class KeyPressTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "KEY_DOWN";
    
    /// <summary>
    /// String representing a keyboard shortcut. Examples: TAB, C, Ctrl+Shift+T, Alt+F3, Win+\.
    /// </summary>
    public string? Shortcut { get; }
    
    /// <summary>
    /// Delay in ms.
    /// </summary>
    public int Delay { get; set; }
}

/// <summary>
/// Mouse enter.
/// </summary>
public sealed class MouseEnterTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "ENTER";
    
    /// <summary>
    /// Delay in ms.
    /// </summary>
    public int Delay { get; set; }
}

/// <summary>
/// Mouse leave.
/// </summary>
public sealed class MouseLeaveTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "LEAVE";
    
    /// <summary>
    /// Delay in ms.
    /// </summary>
    public int Delay { get; set; }
}

/// <summary>
/// Mouse down.
/// </summary>
public sealed class MouseDownTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "MOUSE_DOWN";
    
    /// <summary>
    /// Delay in ms.
    /// </summary>
    public int Delay { get; set; }
}

/// <summary>
/// Mouse up.
/// </summary>
public sealed class MouseUpTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "MOUSE_UP";
    
    /// <summary>
    /// Delay in ms.
    /// </summary>
    public int Delay { get; set; }
}

/// <summary>
/// after delay.
/// </summary>
public sealed class AfterDelayTrigger : FlowTrigger
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "DELAY";
    
    /// <summary>
    /// Delay in ms.
    /// </summary>
    public int Delay { get; set; }
}