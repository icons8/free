namespace Free.Schema;

/// <summary>
/// A hotspot is a special type of layers used to define clickable areas on prototypes.
/// </summary>
public class Hotspot : Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "HOTSPOT";
    
}