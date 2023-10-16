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
    
    [SketchCompatibility]
    public Style? OverlayStyle { get; set; }

    /// <summary>
    /// When enabled, hides the content outside the frame boundaries.
    /// </summary>
    public bool ClipContent { get; set; }
    
    [SketchCompatibility]
    public IGroupLayout? GroupLayout { get; set; }

    /// <summary>
    /// When enabled, the frame background is included into export files.
    /// </summary>
    [SketchCompatibility]
    public bool BackgroundInExport { get; set; }

    /// <summary>
    /// Sets the frame as a prototype starting point.
    /// </summary>
    public bool FlowHome { get; set; }
    public PrototypeViewport Viewport { get; set; }
    
    [SketchCompatibility]
    public OverlayBackgroundInteraction OverlayInteraction { get; set; }
    
    [SketchCompatibility]
    public bool Overlay { get; set; }


    /// <summary>
    /// Enables adjusting and resizing the frame content as the framed is resized.
    /// </summary>
    public bool ResizesContent { get; set; }


    [SketchCompatibility]
    public bool HasBackground { get; set; }
    /// <summary>
    /// Defines the frame background color.
    /// </summary>
    [SketchCompatibility]
    public Color Background { get; set; }
    /// <summary>
    /// Color Variable ID
    /// </summary>
    [SketchCompatibility]
    public Guid BackgroundId { get; set; }
    
    
    public List<IGridLayout> Layouts { get; } = new();
    public Rulers Rulers { get; } = new();
    
    [SketchCompatibility]
    public OverlaySettings? OverlaySettings { get; set; }
    public List<Layer> Layers { get; } = new();
}