namespace Free.Scripts;

public class Node
{
    public NodeType Type { get; set; }
    public string Name { get; set; }
    public string Summary { get; }
    public object? DefaultValue { get; set; }
    public Type? ValueType { get; set; }
    public Type? BaseType { get; set; }
    public Type? ObjectType { get; set; }
    public Attribute[] Attributes { get; set; } = Array.Empty<Attribute>();

    public Node? Parent { get; set; }
    public List<Node> Childs { get; } = new();

    public Node(string name, string summary)
    {
        Type = name.StartsWith("F:") ? NodeType.Field : 
            name.StartsWith("P:") ? NodeType.Property : 
            name.StartsWith("M:") ? NodeType.Method : NodeType.Object;
        Name = name[2..].Replace("Free.Schema.", "");
        Summary = summary.Trim();
    }
    
    public Node(string name, NodeType type = NodeType.Object)
    {
        Type = type;
        Name = name;
        Summary = "";
    }

    public override string ToString() => "[" + Type + "] " + Name + " >> " + Summary;
}