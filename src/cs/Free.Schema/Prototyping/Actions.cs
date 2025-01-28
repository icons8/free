using System.Numerics;

namespace Free.Schema;

/// <summary>
/// Base object of prototyping action.
/// </summary>
public abstract class FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public abstract string _t { get; }
}

/// <summary>
/// Action to navigate to target frame.
/// </summary>
public sealed class NavigateToAction : FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "NAVIGATE";
    /// <summary>
    /// Id of the target frame.
    /// </summary>
    public Guid? Target { get; set; }
    /// <summary>
    /// Id of the target layer.
    /// </summary>
    public FlowAnimation Animation { get; set; }
}

/// <summary>
/// Action to switch state of a target component instance.
/// </summary>
public sealed class SwitchStateAction : FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "SWITCH_STATE";
    /// <summary>
    /// Id of the target instance.
    /// </summary>
    public Guid? Target { get; set; }
    /// <summary>
    /// Id of the target layer.
    /// </summary>
    public FlowAnimation Animation { get; set; }
}

/// <summary>
/// Action to scroll to target layer.
/// </summary>
public sealed class ScrollToAction : FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "SCROLL";
    /// <summary>
    /// Id of the target layer.
    /// </summary>
    public Guid? Target { get; set; }
    /// <summary>
    /// Action animation.
    /// </summary>
    public FlowAnimation Animation { get; set; }
}

/// <summary>
/// Action to open target overlay.
/// </summary>
public sealed class OpenOverlayAction : FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "OVERLAY";
    /// <summary>
    /// Id of the target overlay.
    /// </summary>
    public Guid? Target { get; set; }
    /// <summary>
    /// Action animation.
    /// </summary>
    public FlowAnimation Animation { get; set; }
    /// <summary>
    /// Startup location of overlay.
    /// </summary>
    public FlowOverlayPosition Position { get; set; }
    /// <summary>
    /// Offset from startup location.
    /// </summary>
    public Vector2 Offset { get; set; }
    /// <summary>
    /// Close by any click.
    /// </summary>
    public bool CloseByClick { get; set; }
    /// <summary>
    /// Defines whether the overlay has background.
    /// </summary>
    public bool HasBackground { get; set; }
    /// <summary>
    /// Overlay background color.
    /// </summary>
    public Color Background { get; set; }
}

/// <summary>
/// Action to swap current overlay to target overlay.
/// </summary>
public sealed class SwapOverlayAction : FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "SWAP_OVERLAY";
    /// <summary>
    /// Id of the target overlay.
    /// </summary>
    public Guid? Target { get; set; }
    /// <summary>
    /// Action animation.
    /// </summary>
    public FlowAnimation Animation { get; set; }
}

/// <summary>
/// Action to close current overlay.
/// </summary>
public sealed class CloseOverlayAction : FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "CLOSE_OVERLAY";
}

/// <summary>
/// Action to open URL.
/// </summary>
public sealed class OpenUrlAction : FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "URL";
    /// <summary>
    /// Target URL.
    /// </summary>
    public string Url { get; set; }
}

/// <summary>
/// Action to go to previous frame.
/// </summary>
public sealed class BackAction : FlowAction
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "BACK";
    /// <summary>
    /// Action animation.
    /// </summary>
    public FlowAnimation Animation { get; set; }
}