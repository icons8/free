namespace Free.Schema;

public sealed class NestedComponentOverride : NodeOverride
{
    public Guid? ComponentId { get; set; }

    public override OverrideType Type => OverrideType.NestedComponent;
}