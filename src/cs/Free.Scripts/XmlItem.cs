namespace Free.Scripts;

public class XmlItem
{
    public XmlItemType Type { get; set; }
    public string Name { get; set; }
    public string Summary { get; }

    public List<XmlItem> Childs { get; } = new();

    public XmlItem(string name, string summary)
    {
        Type = name.StartsWith("F:") ? XmlItemType.Field : 
            name.StartsWith("P:") ? XmlItemType.Property : 
            name.StartsWith("M:") ? XmlItemType.Method : XmlItemType.Type;
        Name = name[2..].Replace("Free.Schema.", "");
        Summary = summary.Trim();
    }
    
    public XmlItem(string name)
    {
        Type = XmlItemType.Type;
        Name = name;
        Summary = "";
    }

    public override string ToString() => "[" + Type + "] " + Name + " >> " + Summary;
}