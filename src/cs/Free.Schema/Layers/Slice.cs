namespace Free.Schema;

public class Slice : Layer
{
    public override string _t => "SLICE";
    
    public bool HasBackground { get; set; }
    public Color Background { get; set; }
    /// <summary>
    /// Color Variable ID
    /// </summary>
    public Guid? BackgroundId { get; set; }
}