namespace Free.Schema;

/// <summary>
/// Sketch legacy, not supported in Lunacy
/// </summary>
public enum CornerStyle : byte
{
    Rounded = 0,//Smooth are set from PointRadiusBehavior
    RoundedInverted = 1, //also named as Inside Arc
    Angled = 2,
    Squared = 3,
}