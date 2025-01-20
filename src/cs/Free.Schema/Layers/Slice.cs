namespace Free.Schema;
/// <summary>
/// A slice is a special type of layers used for exporting certaing parts of designs.
/// </summary>
public class Slice : Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
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