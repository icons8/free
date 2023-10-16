namespace Free.Schema;

[LunacySpecific]
public class PhotoInfo
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    /// <summary>
    /// size of low quality image
    /// </summary>
    public Size Size { get; set; }
    /// <summary>
    /// todo
    /// </summary>
    public Size Supersize { get; set; }
}