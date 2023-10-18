using System.Reflection;
using System.Xml.Linq;
using Free.Schema;
using Path = System.IO.Path;

namespace Free.Scripts;

public static class GenerateDocumentationScript
{
    public static void Main()
    {
        var items = FilterItems(GetItemsFromXml());
        ValidateItems(items);
        BuildItemsTree(items);
        Saturate(items);
        items = OrderItems(items);

        var str = new MarkdownBuilder(items).Build();
        File.WriteAllText("1.txt", str);
        Console.WriteLine(str);
    }

    private static void Saturate(List<XmlItem> items)
    {
        var assembly = Assembly.GetAssembly(typeof(Page)) ?? throw new Exception("assembly not loaded");
        foreach (var item in items)
        {
            var type = assembly.GetTypes().First(x=>x.Name == item.Name) ?? throw new Exception("Type not found: " + item.Name);
            if (type.IsEnum)
            {
                item.Type = XmlItemType.Enum;
            }
            else if (type.IsValueType)
            {
                item.Type = XmlItemType.Struct;
            }
            var instance = Activator.CreateInstance(type);
            item.Attributes = type.GetCustomAttributes().ToArray();
            foreach (var child in item.Childs)
            {
                if (child.Type == XmlItemType.Property)
                {
                    var property = type.GetProperty(child.Name) ?? throw new Exception("Property not found: " + item.Name + "." + child.Name);
                    child.Attributes = property.GetCustomAttributes().ToArray();
                    child.DefaultValue = property.GetValue(instance);
                    child.ValueType = property.PropertyType;
                }
                else if (child.Type == XmlItemType.Field)
                {
                    if (item.Type == XmlItemType.Struct)
                    {
                        var field = type.GetField(child.Name) ?? throw new Exception("Field not found: " + item.Name + "." + child.Name);
                        child.Attributes = field.GetCustomAttributes().ToArray();
                        child.DefaultValue = field.GetValue(instance);
                        child.ValueType = field.FieldType;
                    }
                    else if (item.Type == XmlItemType.Enum)
                    {
                        var field = type.GetField(child.Name, BindingFlags.Public | BindingFlags.Static) ?? throw new Exception("Field not found: " + item.Name + "." + child.Name);
                        child.Attributes = field.GetCustomAttributes().ToArray();
                        child.DefaultValue = Convert.ChangeType(field.GetValue(null),Enum.GetUnderlyingType(type));
                    }
                }
            }
        }
    }

    private static List<XmlItem> OrderItems(List<XmlItem> items)
    {
        return items
            .OrderBy(x => x.Attributes.Any(a => a is SketchCompatibilityAttribute))
            .ThenBy(x => x.Attributes.Any(a => a is LunacySpecificAttribute))
            .ThenBy(x => x.Type)
            .ThenBy(x => x.Name)
            .ToList();
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
                item.Parent = parent;
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
                item.Parent = parent;
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
        var ns = doc.Root!.GetDefaultNamespace();
        return doc.Root!
            .Element(ns + "members")!
            .Elements()
            .Select(x => new XmlItem(x.Attribute(ns + "name")!.Value, x.Element(ns + "summary")!.Value))
            .ToArray();
    }
}