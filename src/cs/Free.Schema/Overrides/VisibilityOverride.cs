namespace Free.Schema;

public sealed class VisibilityOverride : NodeOverride
{
    public bool Hidden { get; set; }

    public override OverrideType Type => OverrideType.Visibility;
}