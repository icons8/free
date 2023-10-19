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
        File.WriteAllText("SCHEMA.md", str);
        Console.WriteLine(str);
    }

    private static void Saturate(List<Node> items)
    {
        var assembly = Assembly.GetAssembly(typeof(Page)) ?? throw new Exception("assembly not loaded");
        var types = assembly.GetTypes();

        foreach (var t in types)
        {
            if (t.FullName?.StartsWith("Free.") == true &&
                !t.Name.EndsWith("Attribute") &&
                items.All(x => x.Name != t.Name))
            {
                items.Add(new Node(t.Name, t.IsEnum ? NodeType.Enum : t.IsValueType ? NodeType.Struct : NodeType.Object));
            }
        }
        
        foreach (var item in items)
        {
            var type = types.First(x=>x.Name == item.Name) ?? throw new Exception("Type not found: " + item.Name);
            item.ObjectType = type;
            if (type.IsEnum)
            {
                item.Type = NodeType.Enum;
            }
            else if (type.IsValueType)
            {
                item.Type = NodeType.Struct;
            }
            else if (type.BaseType != typeof(object))
            {
                item.BaseType = type.BaseType;
            }
            var instance = type.IsAbstract || type.IsInterface 
                ? Activator.CreateInstance(types.First(x=>!x.IsInterface && !x.IsAbstract && type.IsAssignableFrom(x))) 
                : Activator.CreateInstance(type);
            item.Attributes = type.GetCustomAttributes().ToArray();
            
            if (item.Type == NodeType.Enum)
            {
                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
                {
                    if (item.Childs.All(x => x.Name != field.Name))
                    {
                        item.Childs.Add(new Node(field.Name, NodeType.Field)
                        {
                            Parent = item
                        });
                    }
                }
            }
            else if (item.Type == NodeType.Object)
            {
                foreach (var prop in type.GetProperties(BindingFlags.Public
                                                        | BindingFlags.Instance
                                                        | BindingFlags.DeclaredOnly))
                {
                    if (item.Childs.All(x => x.Name != prop.Name))
                    {
                        item.Childs.Add(new Node(prop.Name, NodeType.Property)
                        {
                            Parent = item
                        });
                    }
                }
            }
            foreach (var child in item.Childs)
            {
                if (child.Type == NodeType.Property)
                {
                    var property = type.GetProperty(child.Name) ?? throw new Exception("Property not found: " + item.Name + "." + child.Name);
                    child.Attributes = property.GetCustomAttributes().ToArray();
                    child.DefaultValue = property.GetValue(instance);
                    child.ValueType = property.PropertyType;
                }
                else if (child.Type == NodeType.Field)
                {
                    if (item.Type == NodeType.Struct)
                    {
                        var field = type.GetField(child.Name) ?? throw new Exception("Field not found: " + item.Name + "." + child.Name);
                        child.Attributes = field.GetCustomAttributes().ToArray();
                        child.DefaultValue = field.GetValue(instance);
                        child.ValueType = field.FieldType;
                    }
                    else if (item.Type == NodeType.Enum)
                    {
                        var field = type.GetField(child.Name, BindingFlags.Public | BindingFlags.Static) ?? throw new Exception("Field not found: " + item.Name + "." + child.Name);
                        child.Attributes = field.GetCustomAttributes().ToArray();
                        child.DefaultValue = Convert.ChangeType(field.GetValue(null),Enum.GetUnderlyingType(type));
                    }
                }
            }
        }
    }

    private static List<Node> OrderItems(List<Node> items)
    {
        return items
            .OrderBy(x => x.Attributes.Any(a => a is SketchCompatibilityAttribute))
            .ThenBy(x => x.Attributes.Any(a => a is LunacySpecificAttribute))
            .ThenBy(x => x.Type)
            .ThenBy(x => !typeof(Layer).IsAssignableFrom(x.ObjectType))
            .ThenByDescending(GetBaseClassDepth)
            .ThenBy(x => x.Name)
            .ToList();
    }

    private static int GetBaseClassDepth(Node node)
    {
        if (node.Type != NodeType.Object || node.ObjectType?.IsInterface == true)
        {
            return 0;
        }
        var result = 0;
        var current = node.ObjectType;
        while (current != typeof(object))
        {
            current = current.BaseType;
            result++;
        }

        return result;
    }

    private static void BuildItemsTree(List<Node> items)
    {
        foreach (var item in items.ToArray())
        {
            if (item.Type == NodeType.Property)
            {
                var split = item.Name.Split('.');
                if (items.FirstOrDefault(x => x.Name == split[0]) is not { } parent)
                {
                    items.Add(parent = new Node(split[0]));
                }

                parent.Childs.Add(item);
                item.Parent = parent;
                items.Remove(item);
                item.Name = split[1];
            }
            else if (item.Type == NodeType.Field)
            {
                var split = item.Name.Split('.');
                if (items.FirstOrDefault(x => x.Name == split[0]) is not { } parent)
                {
                    items.Add(parent = new Node(split[0]));
                }

                parent.Type = NodeType.Enum;
                parent.Childs.Add(item);
                item.Parent = parent;
                items.Remove(item);
                item.Name = split[1];
            }
        }
    }

    private static void ValidateItems(IEnumerable<Node> items)
    {
        if (items.Any(x => x.Name.Count(c => c == '.') > 2))
        {
            throw new Exception("fix namespaces");
        }
    }

    private static List<Node> FilterItems(Node[] items) => items
        .Where(x => !x.Name.EndsWith("Attribute") && x.Type != NodeType.Method)
        .ToList();

    private static Node[] GetItemsFromXml()
    {
        var path = File.Exists("Free.Schema.xml")
            ? "Free.Schema.xml"
            : Path.Combine("bin", "Debug", "net7.0", "Free.Schema.xml");
        var doc = XDocument.Load(path);
        var ns = doc.Root!.GetDefaultNamespace();
        return doc.Root!
            .Element(ns + "members")!
            .Elements()
            .Select(x => new Node(x.Attribute(ns + "name")!.Value, x.Element(ns + "summary")!.Value))
            .ToArray();
    }
}