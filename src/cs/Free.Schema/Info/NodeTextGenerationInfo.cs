
namespace Free.Schema;

public record NodeTextGenerationInfo : INodeInfo
{
    public DataType DataType { get; set; }
    public DataFieldType DataFieldType { get; set; }
    public string? Format { get; set; }
    
    public NodeTextGenerationInfo() { }
    public NodeTextGenerationInfo(DataType dataType, DataFieldType dataFieldType, string? format = null)
    {
        DataType = dataType;
        DataFieldType = dataFieldType;
        Format = format;
    }
}