using System.Numerics;

namespace Free.Schema;

public abstract class FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public abstract string _t { get; }
}

public sealed class NoneAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "NONE";
}

public sealed class NavigateToAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "NAVIGATE";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
}

public sealed class SwitchStateAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "SWITCH_STATE";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
}

public sealed class ScrollToAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "SCROLL";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
}

public sealed class OpenOverlayAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "OVERLAY";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
    public FlowOverlayPosition Position { get; set; }
    public Vector2 Offset { get; set; }
    public bool CloseByClick { get; set; }
    public bool HasBackground { get; set; }
    public Color Background { get; set; }
}

public sealed class SwapOverlayAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "SWAP_OVERLAY";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
}

public sealed class CloseOverlayAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "CLOSE_OVERLAY";
}

public sealed class OpenUrlAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "URL";
    public string Link { get; set; }
}

public sealed class BackAction : FlowAction
{
    /// <summary>
    /// Object type
    /// </summary>
    public override string _t => "BACK";
    public FlowAnimation Animation { get; set; }
}