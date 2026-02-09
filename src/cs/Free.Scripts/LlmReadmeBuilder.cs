using System.Collections;
using System.Text;
using Free.Schema;

namespace Free.Scripts;

public class LlmReadmeBuilder
{
    private readonly List<Node> _items;
    private readonly StringBuilder _sb = new();

    public LlmReadmeBuilder(List<Node> items)
    {
        _items = items;
    }

    public string Build()
    {
        _sb.Append(File.ReadAllText(PathHelper.FindPath("LlmHeader.md")));
        foreach (var item in _items)
        {
            if (item.Attributes.OfType<SketchCompatibilityAttribute>().Any() ||
                item.Attributes.OfType<LunacySpecificAttribute>().Any())
            {
                continue;
            }
            
            PrintTypeHeader(item);

            if (item.Summary.Length > 0 && !LlmFilter.ObviousDescriptionObjects.Contains(item.Name))
            {
                _sb.Append(" — ").Append(item.Summary.Replace(Environment.NewLine, " "));
            }
            
            _sb.AppendLine();
            _sb.AppendLine();
            
            if (item.Childs.Count == 0)
            {
                if (item.BaseType != null)
                {
                    _sb.Append("See properties for `").Append(item.BaseType.Name).Append("`");
                    _sb.AppendLine();
                }
                continue;
            }
            if (item.BaseType != null)
            {
                _sb.Append("Has all properties of `").Append(item.BaseType.Name).Append("`, plus:");
                _sb.AppendLine();
            }
            PrintFields(item);
        }

        return _sb.ToString();
    }

    private void PrintFields(Node item)
    {
        var basicFields = item.Childs
            .Where(x => x.Attributes.Length == 0)
            .OrderByDescending(x => x.Name.StartsWith('_'))
            .ToArray();

        if (basicFields.Length > 0)
        {
            foreach (var child in basicFields)
            {
                PrintField(child, item.Type);
            }

            _sb.AppendLine();
        }
    }

    private void PrintTypeHeader(Node item)
    {
        _sb.Append("## ");
        if (item.Type != NodeType.Object)
        {
            _sb.Append(item.Type).Append(' ');
        }
        _sb.Append(item.Name);
    }

    private void PrintField(Node child, NodeType parentItemType)
    {
        if (parentItemType == NodeType.Enum)
        {
            if (FormatValue(child.DefaultValue, parentItemType) is { } val)
            {
                _sb.Append(val).Append(". ");
            }
            _sb.Append(child.Name.Substring(0,1).ToLower()).Append(child.Name.Substring(1));
        }
        else if (parentItemType == NodeType.Struct)
        {
            _sb.Append("* ");
            _sb.Append(FormatTypeName(child.ValueType!)).Append(' ');
            _sb.Append(child.Name.Substring(0,1).ToLower()).Append(child.Name.Substring(1));
            if (FormatValue(child.DefaultValue, parentItemType) is {} val)
            {
                _sb.Append(" = ").Append(val);
            }
        }
        else if (child.Type == NodeType.Property)
        {
            _sb.Append("* ");
            _sb.Append(FormatTypeName(child.ValueType!)).Append(' ');
            _sb.Append(child.Name.Substring(0,1).ToLower()).Append(child.Name.Substring(1));
            if (child.Name == "_t" && child.Parent?.Name == "Layer")
            {
                _sb.Append(" — object type");
            }
            else if (FormatValue(child.DefaultValue, parentItemType) is {} val)
            {
                _sb.Append(" = ").Append(val);
            }
        }
        //
        // if (child.Summary.Length > 0 && parentItemType != NodeType.Enum)
        // {
        //     _sb.Append(" //").Append(char.ToLower(child.Summary[0])).Append(child.Summary.Replace(Environment.NewLine, " ").AsSpan(1));
        // }

        _sb.AppendLine();
    }

    private static string? FormatValue(object? value, NodeType parentItemType)
    {
        if (value is null or string{Length:0})
        {
            return null;
        }
        if (value is Point p)
        {
            return "[" + p.X + "," + p.Y + "]";
        }
        if (value is Size s)
        {
            return "[" + s.Width + "," + s.Height + "]";
        }
        if (value is Thickness t)
        {
            return "[" + t.Left + "," + t.Top + "," + t.Right + "," + t.Bottom + "]";
        }
        if (value is Matrix)
        {
            return "[0,0]";
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

        if (parentItemType == NodeType.Struct)
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

        if (!value.GetType().IsValueType && value is not string)
        {
            return null;
        }

        if (value is string str)
        {
            return "\"" + str + "\"";
        }

        if (value is Color c)
        {
            return "\"" + c + "\"";
        }

        if (value is bool b)
        {
            return b ? "true" : "false";
        }

        if (value.GetType().IsEnum)
        {
            return Convert.ToInt32(value).ToString();
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
            .Replace("GUIDe", "Guide")
            .Replace("Single", "float")
            .Replace("Boolean", "bool")
            .Replace("String", "string");
        return name;
    }

}