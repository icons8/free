
namespace Free.Schema;
/// <summary>
/// text generation settings
/// </summary>
[LunacySpecific]
public class DataInfo
{
    public DataType Type { get; set; }
    public DataFieldType Field { get; set; }
    /// <summary>
    /// todo
    /// </summary>
    public string? Format { get; set; }
}