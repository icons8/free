namespace Free.Schema.Document;

public class Foreign
{
    public List<ForeignColorVariable> ColorVariables { get; set; }
    public List<ForeignSharedStyle> LayerStyles { get; set; }
    public List<ForeignSharedStyle> TextStyles { get; set; }
    public List<ForeignComponent> Components { get; set; }
}