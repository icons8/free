using static Free.Utils.HexConverter;

namespace Free;

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
    
    /// <param name="hexString">The hexadecimal string representation of a color.</param>
    /// <param name="color">The new <see cref="Free.Color" /> instance.</param>
    /// <summary>Converts the hexadecimal string representation of a color to its <see cref="Free.Color" /> equivalent.</summary>
    /// <returns>Returns true if the conversion was successful, otherwise false.</returns>
    /// <remarks>This method can parse a string in the forms with or without a preceding '#' character: AARRGGB, RRGGBB, ARGB, RGB, XX, X.</remarks>
    public static bool TryParse(ReadOnlySpan<char> hexString, out Color color)
    {
        hexString = hexString.Trim();
        if (hexString[0] == '#')
        {
            hexString = hexString.Slice(1);
        }

        switch (hexString.Length)
        {
            case 1:
            {
                var digit = DigitFromChar(hexString[0]);
                if (digit == 0xFF)
                {
                    color = default;
                    return false;
                }
                var number = FromDigit(digit);
                color = new Color(number, number, number, byte.MaxValue);
                return true;
            }
            case 2:
            {
                var d1 = DigitFromChar(hexString[0]);
                var d2 = DigitFromChar(hexString[1]);
                if (d1 == 0xFF || d2 == 0xFF)
                {
                    color = default;
                    return false;
                }

                var number = FromDigits(d1, d2);
                color = new Color(number, number, number, byte.MaxValue);
                return true;
            }
            case 3:
            {
                var r = DigitFromChar(hexString[0]);
                var g = DigitFromChar(hexString[1]);
                var b = DigitFromChar(hexString[2]);
                if (r == 0xFF || g == 0xFF || b == 0xFF)
                {
                    color = default;
                    return false;
                }

                color = new Color(FromDigit(r), FromDigit(g), FromDigit(b));
                return true;
            }
            case 4:
            {
                var a = DigitFromChar(hexString[0]);
                var r = DigitFromChar(hexString[1]);
                var g = DigitFromChar(hexString[2]);
                var b = DigitFromChar(hexString[3]);
                if (a == 0xFF || r == 0xFF || g == 0xFF || b == 0xFF)
                {
                    color = default;
                    return false;
                }

                color = new Color(FromDigit(r), FromDigit(g), FromDigit(b), FromDigit(a));
                return true;
            }
            case 6:
            {
                var r1 = DigitFromChar(hexString[0]);
                var r2 = DigitFromChar(hexString[1]);
                var g1 = DigitFromChar(hexString[2]);
                var g2 = DigitFromChar(hexString[3]);
                var b1 = DigitFromChar(hexString[4]);
                var b2 = DigitFromChar(hexString[5]);
                if (r1 == 0xFF || r2 == 0xFF || g1 == 0xFF || g2 == 0xFF || b1 == 0xFF || b2 == 0xFF)
                {
                    color = default;
                    return false;
                }

                color = new Color(FromDigits(r1, r2), FromDigits(g1, g2), FromDigits(b1, b2));
                return true;
            }
            case 8:
            {
                var a1 = DigitFromChar(hexString[0]);
                var a2 = DigitFromChar(hexString[1]);
                var r1 = DigitFromChar(hexString[2]);
                var r2 = DigitFromChar(hexString[3]);
                var g1 = DigitFromChar(hexString[4]);
                var g2 = DigitFromChar(hexString[5]);
                var b1 = DigitFromChar(hexString[6]);
                var b2 = DigitFromChar(hexString[7]);
                if (a1 == 0xFF || a2 == 0xFF ||
                    r1 == 0xFF || r2 == 0xFF || 
                    g1 == 0xFF || g2 == 0xFF || 
                    b1 == 0xFF || b2 == 0xFF)
                {
                    color = default;
                    return false;
                }

                color = new Color(FromDigits(r1, r2), FromDigits(g1, g2), FromDigits(b1, b2), FromDigits(a1, a2));
                return true;
            }
            default:
                color = default;
                return false;
        }
    }
}