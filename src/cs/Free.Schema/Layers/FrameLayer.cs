namespace Free.Schema;

public class FrameLayer : BoxLayer
{
    public Style? OverlayStyle { get; set; }
    public bool ClipContent { get; set; }
    public GroupLayoutBase? GroupLayout { get; set; }
    public bool HasBackground { get; set; }
    public bool BackgroundInExport { get; set; }
    public bool IsFlowHome { get; set; }
    public PrototypeViewport Viewport { get; set; }
    public OverlayBackgroundInteraction OverlayInteraction { get; set; }
    public bool Overlay { get; set; }
    public bool ResizesContent { get; set; }
    public Color Background { get; set; }
    public Guid BackgroundId { get; set; }
    public List<IFrameLayout> Layouts { get; } = new();
    public RulerData HorizontalRuler { get; } = new();
    public RulerData VerticalRuler { get; } = new();
    public OverlaySettings? OverlaySettings { get; set; }
    public List<Layer> Layers { get; } = new();
}