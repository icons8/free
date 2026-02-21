namespace Free.Schema;

/// <summary>
/// A frame is a special type of layers that serves as a container for other layers or layer groups. Frames are a must for auto-layout and prototypes.
/// </summary>
public class Frame : Layer
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "FRAME";

    /// <summary>
    /// When enabled, hides the content outside the frame boundaries.
    /// </summary>
    public bool ClipContent { get; set; } = true;

    /// <summary>
    /// Sets the frame as a prototype starting point.
    /// </summary>
    public bool FlowHome { get; set; }

    /// <summary>
    /// Defines the area that should be displayed on a prototype, when the frame is resized to ensure scrolling effect.
    /// </summary>
    public PrototypeViewport Viewport { get; set; }
    
    /// <summary>
    /// Enables adjusting and resizing the frame content as the frame is resized.
    /// </summary>
    public bool ResizesContent { get; set; }
    
    /// <summary>
    /// Auto Layout Properties
    /// </summary>
    public AutoLayout AutoLayout { get; set; }
    
    /// <summary>
    /// Grid, Row and Column layouts of the frame.
    /// </summary>
    public List<LayoutGuideBase> Layouts { get; } = new();
    /// <summary>
    /// Grid Layout style id.
    /// </summary>
    public Guid GridsId { get; set; }
    /// <summary>
    /// Rulers and guidelines info.
    /// </summary>
    public Rulers Rulers { get; } = new();
    /// <summary>
    /// List of layers on the frame.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}