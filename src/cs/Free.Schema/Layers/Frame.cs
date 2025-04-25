namespace Free.Schema;

/// <summary>
/// A frame is a special type of layers that serves as a container for other layers or layer groups. Frames are a must for prototypes.
/// </summary>

public class Frame : Styled
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "FRAME";

    /// <summary>
    /// When enabled, hides the content outside the frame boundaries.
    /// </summary>
    public bool ClipContent { get; set; }

    /// <summary>
    /// When enabled, the frame background is included into export files.
    /// </summary>
    [SketchCompatibility]
    public bool BackgroundInExport { get; set; }

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
    /// Defines whether the frame has background.
    /// </summary>
    [SketchCompatibility]
    public bool HasBackground { get; set; }

    /// <summary>
    /// Defines the frame background color.
    /// </summary>
    [SketchCompatibility]
    public Color Background { get; set; } = new Color(255, 255, 255);
    /// <summary>
    /// Defines the background color variable ID.
    /// </summary>
    [SketchCompatibility]
    public Guid BackgroundId { get; set; }
    
    /// <summary>
    /// Grid, Row and Column layouts of the frame.
    /// </summary>
    public List<LayoutContainerBase> Layouts { get; } = new();
    /// <summary>
    /// Rulers and guidelines info.
    /// </summary>
    public Rulers Rulers { get; } = new();
    /// <summary>
    /// List of layers on the frame.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}