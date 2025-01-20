using System.Numerics;

namespace Free.Schema;

public abstract class FlowAction
{
    public abstract string _t { get; }
}

public sealed class NoneAction : FlowAction
{
    public override string _t => "NONE";
}

public sealed class NavigateToAction : FlowAction
{
    public override string _t => "NAVIGATE";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
}

public sealed class SwitchStateAction : FlowAction
{
    public override string _t => "SWITCH_STATE";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
}

public sealed class ScrollToAction : FlowAction
{
    public override string _t => "SCROLL";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
}

public sealed class OpenOverlayAction : FlowAction
{
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
    public override string _t => "SWAP_OVERLAY";
    public Guid? Target { get; set; }
    public FlowAnimation Animation { get; set; }
}

public sealed class CloseOverlayAction : FlowAction
{
    public override string _t => "CLOSE_OVERLAY";
}

public sealed class OpenUrlAction : FlowAction
{
    public override string _t => "URL";
    public string Link { get; set; }
}

public sealed class BackAction : FlowAction
{
    public override string _t => "BACK";
    public FlowAnimation Animation { get; set; }
}