namespace Free.Schema;

public enum BoolOp : sbyte
{
    None = -1,
    Union = 0,
    Subtract = 1,
    Intersect = 2,
    Difference = 3,
}