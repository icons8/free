namespace Free.Schema.Document;

/// <summary>
/// Gradients stored in the document (colorpicker>dropdown (global)> document)
/// </summary>
public class GradientAsset : DocumentAssetBase
{
    public Gradient Value { get; set; } = new();
}