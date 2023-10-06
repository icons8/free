namespace Free.Schema;

public enum RadiusBehavior : sbyte
{
    //integer serializable
    Disabled = -1,
    Legacy = 0,
    Rounded = 1,
    Smooth = 2,
}