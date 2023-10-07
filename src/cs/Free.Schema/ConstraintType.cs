namespace Free.Schema;

[Flags]
public enum ConstraintType : byte
{
    //disable all -63 -‭00111111‬
    //Right - 62 - ‭    00111110‬
    //Fit width -61 - ‭ 00111101‬
    //Left - 59 - ‭     00111011‬
    //Bottom - 55 - ‭   00110111‬
    //Fit height -47 - ‭00101111‬
    //Top - 31 - ‭      00011111‬

    None      = 0b00000000,
    Right     = 0b00000001,
    FixWidth  = 0b00000010,
    Left      = 0b00000100,
    Bottom    = 0b00001000,
    FixHeight = 0b00010000,
    Top       = 0b00100000,
    
    All = Left | Top | Right | Bottom
}