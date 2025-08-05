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

        var builder = new FullReadmeBuilder(items);
        var str = builder.Build();
        File.WriteAllText(PathHelper.GetReadmePath("README.md"), str);
        Console.WriteLine(str);

        if (builder.Missing.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine();
            foreach (var miss in builder.Missing)
            {
                Console.WriteLine("[WARNING] Missing description - " + miss);
            }
        }

        items = FilterItemsForLlm(items);
        
        var llmBuilder = new LlmReadmeBuilder(items);
        str = llmBuilder.Build();
        File.WriteAllText(PathHelper.GetReadmePath("llms.txt"), str);

        Console.WriteLine("README.md size: " + new FileInfo(PathHelper.GetReadmePath("README.md")).Length / 1024 + "kb");
        Console.WriteLine("llms.txt size: " + new FileInfo(PathHelper.GetReadmePath("llms.txt")).Length / 1024 + "kb");
    }

    private static readonly string[] LlmFilter = [
        "ComponentType", "Override", 
        
        "Meta", "SharedLibrary",
        
        "LayoutGuideBase", "Rows", "Columns", "Grid", "GuideStyle",
        
        "ComponentPropertyBase", "TextComponentProperty", "SwapComponentProperty", "StateComponentProperty", "BoolComponentProperty",
        
        "VariableTheme", "VariableCollection", "Variable", "StringValue", "FloatValue", "ColorValue", "BoolValue", 
        "StringVariable", "FloatVariable", "ColorVariable", "BoolVariable", "ThemeSelection",
        
        "Flow", "FlowAnimation", "FlowAnimationType", "FlowAnimationEffect", "FlowAnimationDirection", "FlowOverlayPosition", "FlowScrollBehavior",
        "FlowTrigger", "MouseUpTrigger", "MouseLeaveTrigger", "MouseEnterTrigger", "MouseDownTrigger", "KeyPressTrigger",
        "HoverTrigger", "HoldTrigger", "DragTrigger", "ClickTrigger", "AfterDelayTrigger",
        "FlowAction", "SwitchStateAction", "SwapOverlayAction", "ScrollToAction", "OpenUrlAction", "OpenOverlayAction", 
        "NavigateToAction", "CloseOverlayAction", "BackAction", 
        
        "Expression", "ExpressionFunction", "Bind", "BindField", 
    
    ];

    private static readonly Type[] LlmTypeFilter = [
        typeof(List<Flow>), typeof(List<VariableCollection>), typeof(List<Variable>), typeof(List<ThemeSelection>)
    ];
    private static List<Node> FilterItemsForLlm(List<Node> items) => items
        .Where(x => !LlmFilter.Contains(x.Name))
        .Select(x =>
        {
            if (x.Type != NodeType.Enum)
            {
                foreach (var toRemove in x.Childs
                             .Where(c => LlmFilter.Contains(c.ValueType.Name) || 
                                         LlmTypeFilter.Contains(c.ValueType))
                             .ToArray())
                {
                    x.Childs.Remove(toRemove);
                }
            }
            return x;
        })
        .ToList();

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

    public static Type[] VariableRelatedTypes = [typeof(VariableCollection), typeof(VariableTheme), typeof(ColorValue), typeof(BoolValue), typeof(StringValue), typeof(FloatValue)];

    private static List<Node> OrderItems(List<Node> items)
    {
        return items
            .OrderBy(x => x.Attributes.Any(a => a is SketchCompatibilityAttribute))
            .ThenBy(x => x.Attributes.Any(a => a is LunacySpecificAttribute))
            .ThenBy(x => x.Type)
            .ThenBy(x => !typeof(Layer).IsAssignableFrom(x.ObjectType))
            .ThenBy(x => !typeof(Variable).IsAssignableFrom(x.ObjectType) && !VariableRelatedTypes.Contains(x.ObjectType))
            .ThenBy(x => !typeof(ComponentPropertyBase).IsAssignableFrom(x.ObjectType))
            .ThenBy(x => !typeof(StyleBase).IsAssignableFrom(x.ObjectType))
            .ThenBy(x => !typeof(LayoutGuideBase).IsAssignableFrom(x.ObjectType))
            .ThenBy(x => !typeof(FlowAction).IsAssignableFrom(x.ObjectType))
            .ThenBy(x => !typeof(FlowTrigger).IsAssignableFrom(x.ObjectType))
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
        var path = PathHelper.FindPath("Free.Schema.xml");
        var doc = XDocument.Load(path);
        var ns = doc.Root!.GetDefaultNamespace();
        return doc.Root!
            .Element(ns + "members")!
            .Elements()
            .Select(x => new Node(x.Attribute(ns + "name")!.Value, x.Element(ns + "summary")!.Value))
            .ToArray();
    }
}