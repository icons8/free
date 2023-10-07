namespace Free.Schema;

public sealed class VertexCountOverride : NodeOverride
{
    public float VertexCount { get; set; }

    public override OverrideType Type => OverrideType.VertexCount;
}