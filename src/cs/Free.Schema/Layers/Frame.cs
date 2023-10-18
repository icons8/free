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

    /// <summary>
    /// Auto layout settings
    /// </summary>
    public ILayoutContainer? LayoutStrategy { get; set; }

    /// <summary>
    /// Style settings for frame if it's an overlay in sketch prototyping. Only for compatibility.
    /// </summary>
    [SketchCompatibility]
    public Style? OverlayStyle { get; set; }

    /// <summary>
    /// When enabled, hides the content outside the frame boundaries.
    /// </summary>
    public bool ClipContent { get; set; }
    
    /// <summary>
    /// Sketch Layout settings. Not supported in Lunacy. But keeping data for compatibility.
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
    /// if frame has type "resized" (what is displayed in the prototype)
    /// </summary>
    public PrototypeViewport Viewport { get; set; }
    
    /// <summary>
    /// Overlay Interaction for Sketch Prototyping
    /// </summary>
    [SketchCompatibility]
    public OverlayBackgroundInteraction OverlayInteraction { get; set; }
    
    /// <summary>
    /// Is Current frame an overlay in prototyping
    /// </summary>
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
    public Color Background { get; set; } = new Color(255, 255, 255);
    /// <summary>
    /// Color Variable ID
    /// </summary>
    [SketchCompatibility]
    public Guid BackgroundId { get; set; }
    
    
    public List<IGridLayout> Layouts { get; } = new();
    public Rulers Rulers { get; } = new();
    
    /// <summary>
    /// Sketch Prototyping Overlay Feature settings.
    /// </summary>
    [SketchCompatibility]
    public OverlaySettings? OverlaySettings { get; set; }
    public List<Layer> Layers { get; } = new();
}