namespace Free.Schema;

public record NodeBitmapInfo : INodeInfo
{
    public bool UpscalerApplied { get; set; }
    public BackgroundRemovalState BackgroundRemovalState { get; set; }
}