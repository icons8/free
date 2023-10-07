namespace Free.Schema;

public sealed class LockAspectOverride : NodeOverride
{
    public bool LockAspect { get; set; }

    public override OverrideType Type => OverrideType.LockAspect;
}