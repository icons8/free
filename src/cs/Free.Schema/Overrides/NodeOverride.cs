namespace Free.Schema;

public abstract class NodeOverride
{
    public Guid[] Target { get; set; } = Array.Empty<Guid>();
    public abstract OverrideType Type { get; }
}