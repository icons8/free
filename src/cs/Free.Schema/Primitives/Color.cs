namespace Free.Schema;

/// <summary>32-bit ARGB unpremultiplied color value.</summary>
/// <remarks>The color components are always in a known order.</remarks>
public readonly struct Color
{
    private readonly uint _color;

    public Color(uint value) => _color = value;

    public Color(byte red, byte green, byte blue, byte alpha) => _color = (uint) (alpha << 24 | red << 16 | green << 8) | blue;

    public Color(byte red, byte green, byte blue) => _color = (uint) (-16777216 | red << 16 | green << 8) | blue;
    
    /// <summary>Gets the alpha component of the color.</summary>
    public byte Alpha => (byte) (_color >> 24 & byte.MaxValue);

    /// <summary>Gets the red component of the color.</summary>
    public byte Red => (byte) (_color >> 16 & byte.MaxValue);

    /// <summary>Gets the green component of the color.</summary>
    public byte Green => (byte) (_color >> 8 & byte.MaxValue);

    /// <summary>Gets the blue component of the color.</summary>
    public byte Blue => (byte) (_color & byte.MaxValue);

    /// <summary>Returns the color as a string in the format: AARRGGBB.</summary>
    public override string ToString() => $"{Alpha:x2}{Red:x2}{Green:x2}{Blue:x2}";
}