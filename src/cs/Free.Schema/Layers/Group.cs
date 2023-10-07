namespace Free.Schema;

public class Group : Styled
{
    public bool SkipSelect { get; set; }
    public bool SkipConstraints { get; set; }
    public IGroupLayout? GroupLayout { get; set; }
    public List<Layer> Layers { get; } = new();
}