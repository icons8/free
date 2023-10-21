namespace Free.Schema;

/// <summary>
/// Defines the category of generated text.
/// </summary>

[LunacySpecific]
public enum DataType : byte
{
    Unknown,
    Address,
    Article,
    Business,
    Country,
    Date,
    Language,
    Person,
    Technology,
    Time,
}