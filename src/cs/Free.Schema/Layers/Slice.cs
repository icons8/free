namespace Free.Schema;
/// <summary>
/// Slices are a special type of layers used for exporting certaing parts of designs.
/// </summary>
public class Slice : Layer
{
    public override string _t => "SLICE";
    /// <summary>
    /// Defines whether the slice includes background.
    /// </summary>
    public bool HasBackground { get; set; }
    /// <summary>
    /// Defines the background color.
    /// </summary>
    public Color Background { get; set; }
    /// <summary>
    /// Unique color variable ID.
    /// </summary>
    public Guid? BackgroundId { get; set; }
}