namespace Free.Schema;

public sealed class LockOverride : NodeOverride
{
    public bool Locked { get; set; }

    public override OverrideType Type => OverrideType.Lock;
}