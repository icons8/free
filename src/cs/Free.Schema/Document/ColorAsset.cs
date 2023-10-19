namespace Free.Schema;

/// <summary>
/// Colors stored in the document (color picker > dropdown list (global) > document).
/// </summary>
public class ColorAsset : DocumentAssetBase
{
    public Color Color { get; set; }
}