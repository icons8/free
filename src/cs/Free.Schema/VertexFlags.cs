namespace Free.Schema;

[Flags]
public enum VertexFlags : byte
{
    None = 0,
    Mirrored = 1,
    Asymmetric = 1 << 1,
    Disconnected = Asymmetric | Mirrored,
    
    HasCurveFrom = 1 << 2,
    HasCurveTo = 1 << 3,
    
    RoundedInverted = 1 << 4, //also named as Inside Arc
    Angled = 1 << 5,
    Squared = RoundedInverted | Angled,
}