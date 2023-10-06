namespace Free.Schema;

public record NodeIconInfo : INodeInfo
{
    public string? Id { get; set; }
    public int Size { get; set; }
    public bool IsMulticolor { get; set; }
}