namespace Free.Schema;

/// <summary>
/// Defines the type of generated text.
/// </summary>
[LunacySpecific]
public enum DataFieldType : byte
{
    Unknown,
    FullName,
    FirstName,
    LastName,
    Phone,
    Email,

    FullAddress,
    State,
    City,
    ZipCode,

    Theme,
    Header,
    Paragraph,

    Company,
    Department,
    JobTitle,

    Amount,
    CreditCard,

    Day,
    DayOfWeek,
    Year,
    Month,
    DateSlash,
    DateDot,
    DateFull,
    Time12,
    Time24,

    Country,
    Language,

    Url,
    UserName,
    FileName
}