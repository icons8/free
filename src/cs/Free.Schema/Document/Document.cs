namespace Free.Schema.Document;

public class Document
{
    public Guid Id { get; set; }
    public ColorSpace ColorSpace { get; set; }
    public bool FromFigma { get; set; }
    public int CurrentPageIndex { get; set; }
    public List<string> Images { get; } = new();
    public List<ColorAsset> Colors { get; } = new();
    public List<GradientAsset> Gradients { get; } = new();
    public List<Font> Fonts { get; } = new();
    public List<ColorVariable> ColorVariables { get; } = new();
    public List<SharedStyle> LayerStyles { get; } = new();
    public List<SharedStyle> TextStyles { get; } = new();
    public List<Guid> Pages { get; } = new();
}