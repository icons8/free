namespace Free.Schema;

public sealed class ImageOverride : NodeOverride
{
    public string? Image { get; set; }

    public override OverrideType Type => OverrideType.Image;
}