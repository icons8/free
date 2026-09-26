namespace Free.Schema;

public enum ExpressionFunction : byte
{
    /// <summary>
    /// No expression function.
    /// </summary>
    Unknown = 0,

    Add = 1,
    Subtract = 2,
    Multiply = 3,
    Divide = 4,
    
    Equals = 10,
    NotEqual = 11,
    LessThan = 12,
    LessThanOrEqual = 13,
    GreaterThan = 14,
    GreaterThanOrEqual = 15,
    
    And = 20,
    Or = 21,
    Not = 22,
    Negate = 23,
    Ternary = 24,
    IsTruthy = 25,
    
    Stringify = 30,

    /// <summary>
    /// Resolves an instance state during Figma import compatibility processing.
    /// </summary>
    ResolveState = 100,
    /// <summary>
    /// Resolves a value from the selected variable theme.
    /// </summary>
    ThemeLookup = 101,
}
