namespace Free.Schema;

public sealed class TextColorOverride
{
    public Color Color { get; set; }
    /// <summary>
    /// Color Variable ID
    /// </summary>
    public Guid? ColorId { get; set; }
}