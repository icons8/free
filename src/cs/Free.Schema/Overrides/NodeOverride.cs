namespace Free.Schema;

public abstract class NodeOverride
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid[] TargetIds { get; set; } = Array.Empty<Guid>();
    public abstract OverrideType Type { get; }
}