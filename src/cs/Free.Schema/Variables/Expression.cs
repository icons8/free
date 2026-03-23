namespace Free.Schema;

/// <summary>
/// Expression
/// </summary>
public class Expression
{
    /// <summary>
    /// Expression Function
    /// </summary>
    public ExpressionFunction Func { get; set; }

    /// <summary>
    /// List of expression arguments.
    /// </summary>
    public List<Argument> Args { get; } = new();
}