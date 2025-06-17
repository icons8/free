namespace Free.Schema;

/// <summary>
/// Defines component property of components and states.
/// </summary>
public abstract class ComponentPropertyBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public abstract string _t { get; }
    
    /// <summary>
    /// Unique property identifier.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Defines property name.
    /// </summary>
    public string Name { get; set; } = "";
    
    /// <summary>
    /// Is already deleted.
    /// </summary>
    public bool Dead { get; set; }
}

/// <summary>
/// Defines boolean component property of components and states.
/// </summary>
public class BoolComponentProperty : ComponentPropertyBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "BOOL";
    
    /// <summary>
    /// Initial Value.
    /// </summary>
    public bool Value { get; set; }
}

/// <summary>
/// Defines text component property of components and states.
/// </summary>
public class TextComponentProperty : ComponentPropertyBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "TEXT";
    
    /// <summary>
    /// Initial Value.
    /// </summary>
    public string Value { get; set; } = "";
}

/// <summary>
/// Defines swap component property of components and states.
/// </summary>
public class SwapComponentProperty : ComponentPropertyBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "SWAP";
    
    /// <summary>
    /// Initial Value.
    /// </summary>
    public Guid Value { get; set; }
    
    /// <summary>
    /// Preferred Values.
    /// </summary>
    public List<Guid> Values { get; set; } = new();
}

/// <summary>
/// Defines state(variant) component property of components and states.
/// </summary>
public class StateComponentProperty : ComponentPropertyBase
{
    /// <summary>
    /// Object type.
    /// </summary>
    public override string _t => "STATE";
    
    /// <summary>
    /// Initial Value.
    /// </summary>
    public string Value { get; set; } = "";

    /// <summary>
    /// Preferred Values.
    /// </summary>
    public List<string> Values { get; set; } = new();
}