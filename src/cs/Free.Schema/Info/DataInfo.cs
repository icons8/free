
namespace Free.Schema;
/// <summary>
/// Information about auto generated texts.
/// </summary>
[LunacySpecific]
public class DataInfo
{
    /// <summary>
    /// Category of generated text (person, address, date, etc.).
    /// </summary>
    public DataType Type { get; set; }
    /// <summary>
    /// Type of generated text (full name or first name, city or ZIP code, etc.).
    /// </summary>
    public DataFieldType Field { get; set; }
    /// <summary>
    /// Format for Data Type. Used for Date/Time values.
    /// </summary>
    public string? Format { get; set; }
}