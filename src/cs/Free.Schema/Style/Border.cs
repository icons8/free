namespace Free.Schema;

public sealed class Border : Fill
{
    public Thickness Thickness { get; set; }
    public BorderPosition Pos { get; set; } = BorderPosition.Center;
}