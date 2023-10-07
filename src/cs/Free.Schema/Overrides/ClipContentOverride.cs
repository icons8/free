namespace Free.Schema;

public sealed class ClipContentOverride : NodeOverride
{
    public bool ClipContent { get; set; }

    public override OverrideType Type => OverrideType.ClipContent;
}