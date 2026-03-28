namespace Free.Schema;

/// <summary>
/// Expression Argument. Value or Variable or Expression.
/// </summary>
public class Argument
{
    /// <summary>
    /// Boolean value
    /// </summary>
    public bool? Bool { get; set; }
    /// <summary>
    /// Number value
    /// </summary>
    public float? Number { get; set; }
    /// <summary>
    /// Text value
    /// </summary>
    public string? Text { get; set; }
    /// <summary>
    /// Id of a variable or component.
    /// For variable there should be a bool/float/string value before id.
    /// </summary>
    public Guid? Id { get; set; }
    
    /// <summary>
    /// Expression Function. Use only with Args.
    /// </summary>
    public ExpressionFunction? Func { get; set; }
    /// <summary>
    /// List of expression arguments. Use only with Func.
    /// </summary>
    public List<Argument> Args { get; } = new();
}