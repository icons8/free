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
    /// List of expression arguments. Can be: bool, float, string and a Variable(bool/float/string).
    /// </summary>
    public List<object> Args { get; } = new();
}