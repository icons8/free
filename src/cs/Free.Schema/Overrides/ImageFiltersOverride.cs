namespace Free.Schema;

public sealed class ImageFiltersOverride : NodeOverride
{
    public ImageFilters ImageFilters { get; } = new();

    public override OverrideType Type => OverrideType.ImageFilters;
}