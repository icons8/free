namespace Free.Schema;
/// <summary>
/// Defines the appearance of borders.
/// </summary>
public sealed class Border : Fill
{
    /// <summary>
    /// Defines border thickness.
    /// </summary>
    public Thickness Thickness { get; set; }
    /// <summary>
    /// Defines border position.
    /// </summary>
    public BorderPosition Pos { get; set; } = BorderPosition.Center;
}