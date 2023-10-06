namespace Free.Schema.Document;

public class GradientAsset : DocumentAssetBase
{
    public Gradient Value { get; set; } = new();
}