namespace Free.Schema;

public sealed class LockOverride : NodeOverride
{
    public bool IsLocked { get; set; }

    public override OverrideType Type => OverrideType.Lock;
}