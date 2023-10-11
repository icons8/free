namespace Free.Schema;

public class Frame : Styled
{
    public float[] CornerRadius { get; set; } = new float[4];
    public RadiusBehavior RadiusBehavior { get; set; } = RadiusBehavior.Rounded;
    public ILayoutContainer? LayoutStrategy { get; set; }
    
    public Style? OverlayStyle { get; set; }
    public bool ClipContent { get; set; }
    public IGroupLayout? GroupLayout { get; set; }
    public bool HasBackground { get; set; }
    public bool BackgroundInExport { get; set; }
    public bool FlowHome { get; set; }
    public PrototypeViewport Viewport { get; set; }
    public OverlayBackgroundInteraction OverlayInteraction { get; set; }
    public bool Overlay { get; set; }
    public bool ResizesContent { get; set; }
    public Color Background { get; set; }
    public Guid BackgroundId { get; set; }
    public List<IGridLayout> Layouts { get; } = new();
    public Rulers Rulers { get; } = new();
    public OverlaySettings? OverlaySettings { get; set; }
    public List<Layer> Layers { get; } = new();
}