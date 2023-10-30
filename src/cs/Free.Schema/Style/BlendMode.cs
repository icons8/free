namespace Free.Schema;
/// <summary>
/// Defines the type of blend mode applied to a layer.
/// </summary>
public enum BlendMode : byte
{
    Normal = 0,

    Darken = 1,
    Multiply = 2,
    ColorBurn = 3,

    Lighten = 4,
    Screen = 5,
    ColorDodge = 6,

    Overlay = 7,
    SoftLight = 8,
    HardLight = 9,

    Difference = 10,
    Exclusion = 11,

    Hue = 12,
    Saturation = 13,
    Color = 14,
    Luminosity = 15,

    PlusDarker = 16,
    PlusLighter = 17
}