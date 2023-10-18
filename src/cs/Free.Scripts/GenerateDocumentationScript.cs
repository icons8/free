// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Xml.Linq;

namespace Free.Scripts;

public static class GenerateDocumentationScript
{
    public static void Main()
    {
        var items = FilterItems(GetItemsFromXml());
        ValidateItems(items);
        BuildItemsTree(items);
        items = OrderItems(items);

        var str = BuildMarkdown(items);
        File.WriteAllText("1.txt", str);
        Console.WriteLine(str);
    }

    private static List<XmlItem> OrderItems(List<XmlItem> items)
    {
        return items.OrderBy(x => x.Type).ThenBy(x => x.Name).ToList();
    }

    private static string BuildMarkdown(List<XmlItem> items)
    {
        var sb = new StringBuilder();
        
        foreach (var item in items)
        {
            sb.Append("## ").Append(item.Name).Append(" [").Append(item.Type).Append("] ").AppendLine();
            sb.AppendLine(item.Summary);
            if (item.Summary.Length > 0)
            {
                sb.AppendLine();
            }
            if (item.Childs.Count == 0)
            {
                continue;
            }
            foreach (var child in item.Childs)
            {
                sb.AppendLine("* " + child.Name + (child.Summary.Length == 0 ? "" : " - " + child.Summary));
            }
            sb.AppendLine();
        }

        return sb.ToString();
    }

    private static void BuildItemsTree(List<XmlItem> items)
    {
        foreach (var item in items.ToArray())
        {
            if (item.Type == XmlItemType.Property)
            {
                var split = item.Name.Split('.');
                if (items.FirstOrDefault(x => x.Name == split[0]) is not { } parent)
                {
                    items.Add(parent = new XmlItem(split[0]));
                }

                parent.Childs.Add(item);
                items.Remove(item);
                item.Name = split[1];
            }
            else if (item.Type == XmlItemType.Field)
            {
                var split = item.Name.Split('.');
                if (items.FirstOrDefault(x => x.Name == split[0]) is not { } parent)
                {
                    items.Add(parent = new XmlItem(split[0]));
                }

                parent.Type = XmlItemType.Enum;
                parent.Childs.Add(item);
                items.Remove(item);
                item.Name = split[1];
            }
        }
    }

    private static void ValidateItems(IEnumerable<XmlItem> items)
    {
        if (items.Any(x => x.Name.Count(c => c == '.') > 2))
        {
            throw new Exception("fix namespaces");
        }
    }

    private static List<XmlItem> FilterItems(XmlItem[] items) => items
        .Where(x => !x.Name.EndsWith("Attribute") && x.Type != XmlItemType.Method)
        .ToList();

    private static XmlItem[] GetItemsFromXml()
    {
        var path = File.Exists("Free.Schema.xml")
            ? "Free.Schema.xml"
            : Path.Combine("bin", "Debug", "net7.0", "Free.Schema.xml");
        var doc = XDocument.Load(path);
        var ns = doc.Root.GetDefaultNamespace();
        return doc.Root
            .Element(ns + "members")
            .Elements()
            .Select(x => new XmlItem(x.Attribute(ns + "name").Value, x.Element(ns + "summary").Value))
            .ToArray();
    }
}