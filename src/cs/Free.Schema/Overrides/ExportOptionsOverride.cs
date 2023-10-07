namespace Free.Schema;

public sealed class ExportOptionsOverride : NodeOverride
{
    public ExportOptions ExportOptions { get; } = new();

    public override OverrideType Type => OverrideType.ExportOptions;
}