namespace Free.Schema;

public sealed class ExportOptionsOverride : NodeOverride
{
    public ExportOptions Export { get; } = new();

    public override OverrideType Type => OverrideType.ExportOptions;
}