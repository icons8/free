using System.Collections;
using System.Text;
using Free.Schema;

namespace Free.Scripts;

public class MarkdownBuilder
{
    private readonly List<Node> _items;
    private readonly StringBuilder _sb = new();

    public MarkdownBuilder(List<Node> items)
    {
        _items = items;
    }

    public string Build()
    {
        foreach (var item in _items)
        {
            PrintTypeHeader(item);
            _sb.Append(item.Summary);
            if (item.Attributes.OfType<SketchCompatibilityAttribute>().Any())
            {
                _sb.Append(" _//Sketch Compatibility_");
            }

            if (item.Attributes.OfType<LunacySpecificAttribute>().Any())
            {
                _sb.Append(" _//Lunacy Specific_");
            }
            _sb.AppendLine();
            if (item.Summary.Length > 0)
            {
                _sb.AppendLine();
            }
            if (item.Childs.Count == 0)
            {
                if (item.BaseType != null)
                {
                    _sb.Append("See properties for [`").Append(item.BaseType.Name).Append("`](#").Append(item.BaseType.Name).AppendLine(")");
                    _sb.AppendLine();
                }
                continue;
            }
            if (item.BaseType != null)
            {
                _sb.Append("Has all properties of [`").Append(item.BaseType.Name).Append("`](#").Append(item.BaseType.Name).AppendLine("), plus:");
                _sb.AppendLine();
            }
            foreach (var child in item.Childs)
            {
                PrintField(child, item.Type);
            }
            _sb.AppendLine();
        }

        return _sb.ToString();
    }

    private void PrintTypeHeader(Node item)
    {
        _sb.Append("## ").Append("<a name=\"").Append(item.Name).Append("\"></a>").Append(item.Name);
        if (item.Type != NodeType.Object)
        {
            _sb.Append(' ').Append(item.Type);
        }
        _sb.AppendLine();
    }

    private void PrintField(Node child, NodeType parentItemType)
    {
        _sb.Append("* ");

        if (parentItemType == NodeType.Enum)
        {
            if (FormatValue(child.DefaultValue, parentItemType) is { } val)
            {
                _sb.Append('`').Append(val).Append("` ");
            }
            _sb.Append(child.Name);
        }
        else if (parentItemType == NodeType.Struct)
        {
            _sb.Append(child.Name);
            PrintTypeName(child.ValueType!);
            if (FormatValue(child.DefaultValue, parentItemType) is {} val)
            {
                _sb.Append(" = `").Append(val).Append('`');
            }
        }
        else if (child.Type == NodeType.Property)
        {
            _sb.Append(child.Name);
            PrintTypeName(child.ValueType!);
            if (FormatValue(child.DefaultValue, parentItemType) is {} val)
            {
                _sb.Append(" = `").Append(val).Append('`');
            }
        }

        if (child.Summary.Length > 0)
        {
            _sb.Append(" - ").Append(child.Summary);
        }

        if (child.Attributes.OfType<SketchCompatibilityAttribute>().Any())
        {
            _sb.Append(" _//Sketch Compatibility_");
        }

        if (child.Attributes.OfType<LunacySpecificAttribute>().Any())
        {
            _sb.Append(" _//Lunacy Specific_");
        }

        _sb.AppendLine();
    }

    private static string? FormatValue(object? value, NodeType parentItemType)
    {
        if (value is null or string{Length:0} or Rulers or TextStyle)
        {
            return null;
        }
        if (value is Point p)
        {
            return "[" + p.X + "," + p.Y + "]";
        }

        if (value is ICollection { Count: 0 })
        {
            return null;
        }
        if (value is float[] f)
        {
            return "float[" + f.Length + "]";
        }

        if (value is Guid)
        {
            return null;
        }

        if (parentItemType != NodeType.Enum)
        {
            if (value is 0)
            {
                return null;
            }
            if (value is 0f)
            {
                return null;
            }
        }

        return value.ToString();
    }

    private static string FormatTypeName(Type propertyType)
    {
        var name = propertyType.Name;
        if (name == "List`1")
        {
            name = propertyType.GenericTypeArguments[0].Name + "[]";
        }
        if (name == "Nullable`1")
        {
            name = propertyType.GenericTypeArguments[0].Name + "?";
        }

        if (name == "Dictionary`2")
        {
            name = "[" + propertyType.GenericTypeArguments[0].Name + "," + propertyType.GenericTypeArguments[1].Name + "]";
        }
        name = name
            .Replace("Int32", "int")
            .Replace("Byte", "byte")
            .Replace("Guid", "GUID")
            .Replace("Single", "float")
            .Replace("Boolean", "bool")
            .Replace("String", "string");
        return name;
    }
    private void PrintTypeName(Type type)
    {
        var name = FormatTypeName(type);
        var clearName = name.TrimEnd('[', ']', '?');
        _sb.Append(": [").Append(name).Append("](#").Append(clearName).Append(')');
    }

}