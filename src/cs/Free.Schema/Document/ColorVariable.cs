namespace Free.Schema;

public class ColorVariable : DocumentAssetBase
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Color Value { get; set; }
}