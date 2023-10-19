namespace Free.Schema;

/// <summary>
/// Gradients stored in the document (color picker > dropdown list (global) > document).
/// </summary>
public class GradientAsset : DocumentAssetBase
{
    /// <summary>
    /// Values of gradients.
    /// </summary>
    public Gradient Value { get; set; } = new();
}