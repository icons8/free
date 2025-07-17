namespace Free.Schema;

/// <summary>
/// Base class of variable.
/// </summary>
public abstract class Variable
{
    /// <summary>
    /// Variable type.
    /// </summary>
    public abstract string _t { get; }
    
    /// <summary>
    /// Unique variable ID.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Variable name.
    /// </summary>
    public string Name { get; set; } = "";
    
    /// <summary>
    /// Variable version.
    /// </summary>
    public int Version { get; set; }
}

/// <summary>
/// Variable with a color value.
/// </summary>
public class ColorVariable : Variable
{
    /// <summary>
    /// Variable type.
    /// </summary>
    public override string _t => "COLOR";

    /// <summary>
    /// Variable modes to color values map.
    /// </summary>
    public List<ColorValue> Values { get; } = new();
}

/// <summary>
/// Variable with a boolean value.
/// </summary>
public class BoolVariable : Variable
{
    /// <summary>
    /// Variable type.
    /// </summary>
    public override string _t => "BOOL";
    
    /// <summary>
    /// Variable modes to boolean values map.
    /// </summary>
    public List<BoolValue> Values { get; } = new();
}

/// <summary>
/// Variable with a string value.
/// </summary>
public class StringVariable : Variable
{
    /// <summary>
    /// Variable type.
    /// </summary>
    public override string _t => "TEXT";

    /// <summary>
    /// Variable modes to string values map.
    /// </summary>
    public List<StringValue> Values { get; } = new();
}

/// <summary>
/// Variable with a float value.
/// </summary>
public class FloatVariable : Variable
{
    /// <summary>
    /// Variable type.
    /// </summary>
    public override string _t => "FLOAT";
    
    /// <summary>
    /// Variable modes to float values map.
    /// </summary>
    public List<FloatValue> Values { get; } = new();
}