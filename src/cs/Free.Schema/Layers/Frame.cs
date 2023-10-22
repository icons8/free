namespace Free.Schema;

/// <summary>
/// Frames are a special type of layers that serves as a container for other layers or layer groups. Frames are a must for prototypes.
/// </summary>

public class Frame : Styled
{
    public override string _t => "FRAME";
    
    /// <summary>
    /// Sets the corner radius of the frame.
    /// </summary>
    public float[] CornerRadius { get; set; } = new float[4];
    /// <summary>
    /// Enables smooth rounded corners like in iOS interfaces.
    /// </summary>
    public bool SmoothCorners { get; set; }

    /// <summary>
    /// Auto layout settings.
    /// </summary>
    public ILayoutContainer? LayoutStrategy { get; set; }

    /// <summary>
    /// Style settings for the frame if it acts an overlay in Sketch prototyping. For compatibility with Sketch only.
    /// </summary>
    [SketchCompatibility]
    public Style? OverlayStyle { get; set; }

    /// <summary>
    /// When enabled, hides the content outside the frame boundaries.
    /// </summary>
    public bool ClipContent { get; set; }
    
    /// <summary>
    /// Sketch Layout settings. Not supported in Lunacy, but keeping data for compatibility.
    /// </summary>
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

    /// <summary>
    /// Defines the area that should be displayed on a prototype, if the frame is resized to ensure scrolling effect.
    /// </summary>
    public PrototypeViewport Viewport { get; set; }
    
    /// <summary>
    /// Overlay interaction for Sketch prototyping.
    /// </summary>
    [SketchCompatibility]
    public OverlayBackgroundInteraction OverlayInteraction { get; set; }
    
    /// <summary>
    /// Defines whether the frame acts as an overlay in prototyping.
    /// </summary>
    [SketchCompatibility]
    public bool Overlay { get; set; }


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
    /// ????????
    /// </summary>
    public List<IGridLayout> Layouts { get; } = new();
    /// <summary>
    /// ?????????????
    /// </summary>
    public Rulers Rulers { get; } = new();
    
    /// <summary>
    /// Sketch prototyping overlay feature settings.
    /// </summary>
    [SketchCompatibility]
    public OverlaySettings? OverlaySettings { get; set; }
    /// <summary>
    /// List of layers on the frame.
    /// </summary>
    public List<Layer> Layers { get; } = new();
}