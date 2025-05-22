namespace Free.Schema;

/// <summary>
/// Prototyping interaction element
/// </summary>
public sealed class Flow
{
    /// <summary>
    /// Trigger that will fire an action. Examples: CLICK, DRAG, HOLD.
    /// </summary>
    public FlowTrigger Trigger { get; set; }

    /// <summary>
    /// List of Actions. Examples: NAVIGATE, SCROLL, URL, BACK.
    /// </summary>
    public List<FlowAction> Actions { get; set; } = new();
}