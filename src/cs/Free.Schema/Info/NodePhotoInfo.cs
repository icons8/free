namespace Free.Schema;

public record NodePhotoInfo : INodeInfo
{
    public string? MoosePhotoId { get; set; }
    public string? IllustrationId { get; set; }
    public string? ContentName { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int SupersizeWidth { get; set; }
    public int SupersizeHeight { get; set; }
}