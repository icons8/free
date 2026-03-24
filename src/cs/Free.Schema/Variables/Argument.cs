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
    /// Id of a variable. Should be used with a bool/float/string value before id.
    /// </summary>
    public Guid? Id { get; set; }
    /// <summary>
    /// Argument of an expression can be expression itself
    /// </summary>
    public Expression? Expr { get; set; }
}