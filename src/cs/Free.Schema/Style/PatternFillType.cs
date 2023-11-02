namespace Free.Schema;
/// <summary>
/// Defines the image fill type.
/// </summary>
public enum PatternFillType : byte
{
    /// <summary>
    /// Tile. Duplicates the image in a tile pattern to fit the layer. The size of tiles is adjustable.
    /// </summary>
    Tile = 0,
    /// <summary>
    /// Fill. Adjusts the image size to the layer’s width.
    /// </summary>
    Fill = 1,
    /// <summary>
    /// Stretch. Stretches the image to fit the layer’s width and height.
    /// </summary>
    Stretch = 2,
    /// <summary>
    /// Fit. Adjusts the image size to fit the layer’s height.
    /// </summary>
    Fit = 3,
    /// <summary>
    /// Crop. Crops the image at user's discretion.
    /// </summary>
    Crop = 4
}