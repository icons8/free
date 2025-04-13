namespace Free.Schema;

/// <summary>
/// Root group of layers. Can be a child of a page or another section.
/// Does not support rotation, flips, effects.
/// </summary>
public class Section : Styled
{
    public override string _t => "SECTION";
    
    /// <summary>
    /// List of layers within the section.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}