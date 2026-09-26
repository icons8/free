namespace Free.Schema;

/// <summary>
/// Expression Argument. Value or Variable or Expression.
/// Please note that only one type of value can be present:
/// just a bool/text/number,
/// a numberId with an optional number fallback,
/// just a boolId or textId,
/// just a ref,
/// just a componentId,
/// a list of variable font axis values,
/// or a func with args.
/// </summary>
public class Argument
{
    /// <summary>
    /// Boolean value
    /// </summary>
    public bool? Bool { get; set; }
    /// <summary>
    /// Id of a boolean variable
    /// </summary>
    public Guid? BoolId { get; set; }
    
    /// <summary>
    /// Number value
    /// </summary>
    public float? Number { get; set; }
    /// <summary>
    /// Id of a number variable
    /// </summary>
    public Guid? NumberId { get; set; }
    
    /// <summary>
    /// Text value
    /// </summary>
    public string? Text { get; set; }
    /// <summary>
    /// Id of a Text variable
    /// </summary>
    public Guid? TextId { get; set; }
    
    /// <summary>
    /// Id of a component.
    /// </summary>
    public Guid? ComponentId { get; set; }
    
    /// <summary>
    /// Map. Used for state binds.
    /// </summary>
    public MapEntry[]? Map { get; set; }

    /// <summary>
    /// Variable font axis values. Each entry contains an axis tag and a number or number variable.
    /// </summary>
    public List<FontVariationValue>? VariationValues { get; set; }
    
    /// <summary>
    /// Id of Component Property.
    /// </summary>
    public Guid? Ref { get; set; }
    
    /// <summary>
    /// Expression Function. Use only with Args.
    /// </summary>
    public ExpressionFunction? Func { get; set; }
    /// <summary>
    /// List of expression arguments. Use only with Func.
    /// </summary>
    public List<Argument> Args { get; } = new();
}

/// <summary>
/// A variable font axis value used by a FontVariations bind.
/// </summary>
public class FontVariationValue
{
    /// <summary>
    /// Four-character OpenType axis tag, for example wght or wdth.
    /// </summary>
    public string Axis { get; set; }
    /// <summary>
    /// Numeric axis value or fallback for NumberId.
    /// </summary>
    public float? Number { get; set; }
    /// <summary>
    /// Id of a float variable that controls the axis.
    /// </summary>
    public Guid? NumberId { get; set; }
}
