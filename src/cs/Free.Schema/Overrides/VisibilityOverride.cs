namespace Free.Schema;

public sealed class VisibilityOverride : NodeOverride
{
    public bool IsVisible { get; set; }

    public override OverrideType Type => OverrideType.Visibility;
}