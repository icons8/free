namespace Free.Schema;

/// <summary>
/// Frames are a special type of layer that serves as a container for other layers or layer groups. Frames are a must for prototypes.
/// </summary>

public class Frame : Styled
{
    public override string _t => "FRAME";
    
    /// <summary>
    /// Sets the corner radius of the frame.
    /// </summary>
    public float[] CornerRadius { get; set; } = new float[4];
    public bool SmoothCorners { get; set; }
    public ILayoutContainer? LayoutStrategy { get; set; }
    
    public Style? OverlayStyle { get; set; }

    /// <summary>
    /// When enabled, hides the content outside the frame boundaries.
    /// </summary>
    public bool ClipContent { get; set; }
    public IGroupLayout? GroupLayout { get; set; }
    public bool HasBackground { get; set; }

    /// <summary>
    /// When enabled, the frame background is included into export files.
    /// </summary>
    public bool BackgroundInExport { get; set; }

    /// <summary>
    /// Sets the frame as a prototype starting point.
    /// </summary>
    public bool FlowHome { get; set; }
    public PrototypeViewport Viewport { get; set; }
    public OverlayBackgroundInteraction OverlayInteraction { get; set; }
    public bool Overlay { get; set; }


    /// <summary>
    /// Enables adjusting and resizing the frame content as the framed is resized.
    /// </summary>
    public bool ResizesContent { get; set; }


    /// <summary>
    /// Defines the frame background color.
    /// </summary>
    public Color Background { get; set; }
    public Guid BackgroundId { get; set; }
    public List<IGridLayout> Layouts { get; } = new();
    public Rulers Rulers { get; } = new();
    public OverlaySettings? OverlaySettings { get; set; }
    public List<Layer> Layers { get; } = new();
}