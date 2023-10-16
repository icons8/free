namespace Free.Schema;

[LunacySpecific]
public class PhotoInfo
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public Size Size { get; set; }
    public Size Supersize { get; set; }
}