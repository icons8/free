using System.Collections;
using System.Text;
using Free.Schema;

namespace Free.Scripts;

public class MarkdownBuilder
{
    private readonly List<XmlItem> _items;
    private readonly StringBuilder _sb = new();

    public MarkdownBuilder(List<XmlItem> items)
    {
        _items = items;
    }

    public string Build()
    {
        foreach (var item in _items)
        {
            PrintTypeHeader(item);
            _sb.AppendLine(item.Summary);
            if (item.Summary.Length > 0)
            {
                _sb.AppendLine();
            }
            if (item.Childs.Count == 0)
            {
                continue;
            }
            foreach (var child in item.Childs)
            {
                PrintField(child, item.Type);
            }
            _sb.AppendLine();
        }

        return _sb.ToString();
    }

    private void PrintTypeHeader(XmlItem item)
    {
        _sb.Append("## ").Append(item.Name);
        if (item.Type != XmlItemType.Object)
        {
            _sb.Append(" [").Append(item.Type).Append(']');
        }

        if (item.Attributes.OfType<SketchCompatibilityAttribute>().Any())
        {
            _sb.Append(" //Sketch Compatibility");
        }

        if (item.Attributes.OfType<LunacySpecificAttribute>().Any())
        {
            _sb.Append(" //Lunacy Specific");
        }

        _sb.AppendLine();
    }

    private void PrintField(XmlItem child, XmlItemType parentItemType)
    {
        _sb.Append("* ").Append(child.Name);
        if (child.Type == XmlItemType.Field)
        {
            if (parentItemType == XmlItemType.Struct)
            {
                _sb.Append(": ").Append(FormatTypeName(child.ValueType!));
            }
            if (FormatValue(child.DefaultValue, parentItemType) is {} val)
            {
                _sb.Append(" = ").Append(val);
            }
        }
        else if (child.Type == XmlItemType.Property)
        {
            _sb.Append(": ").Append(FormatTypeName(child.ValueType!));
            if (FormatValue(child.DefaultValue, parentItemType) is {} val)
            {
                _sb.Append(" = ").Append(val);
            }
        }

        if (child.Summary.Length > 0)
        {
            _sb.Append(" - ").Append(child.Summary);
        }

        if (child.Attributes.OfType<SketchCompatibilityAttribute>().Any())
        {
            _sb.Append(" //Sketch Compatibility");
        }

        if (child.Attributes.OfType<LunacySpecificAttribute>().Any())
        {
            _sb.Append(" //Lunacy Specific");
        }

        _sb.AppendLine();
    }
    
    private static string? FormatValue(object? value, XmlItemType parentItemType)
    {
        if (value == null)
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

        if (parentItemType != XmlItemType.Enum)
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
        name = name
            .Replace("Int32", "int")
            .Replace("Byte", "byte")
            .Replace("Guid", "GUID")
            .Replace("Single", "float")
            .Replace("Boolean", "bool")
            .Replace("String", "string");
        return name;
    }
}