namespace Free.Schema;

/// <summary>
/// Colors stored in the document (colorpicker>dropdown (global)> document)
/// </summary>
public class ColorAsset : DocumentAssetBase
{
    public Color Color { get; set; }
}