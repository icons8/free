namespace Free.Schema;

/// <summary>
/// Expression Argument. Value or Variable or Expression.
/// Please note that only one type of value can be present:
/// just a bool/text/number,
/// bool and boolId(same for text and number),
/// just a ref,
/// just a componentId,
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