namespace Free.Schema;

public class NodeExportFormat
{
    public float Size { get; set; }

    public string Format { get; set; } = "png";

    public string Name { get; set; } = "";

    public NamingScheme Naming { get; set; } = NamingScheme.Suffix;

    public float Scale { get; set; }

    public VisibleScaleType Type { get; set; } = VisibleScaleType.Scale;
}