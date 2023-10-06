namespace Free.Schema;

public sealed class Border : Fill
{
    public Thickness Thickness { get; set; }
    public BorderPosition Position { get; set; } = BorderPosition.Center;
}