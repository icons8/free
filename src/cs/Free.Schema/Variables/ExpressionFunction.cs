namespace Free.Schema;

public enum ExpressionFunction : byte
{
    Add = 0,
    Subtract = 1,
    Multiply = 2,
    Divide = 3,
    
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
    
    ResolveState = 100,
    ThemeLookup = 101,
}