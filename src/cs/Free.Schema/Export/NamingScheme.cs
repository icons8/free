namespace Free.Schema;

/// <summary>
/// scheme for names of imported objects (suffix/preffix)
/// </summary>
[SketchCompatibility]
public enum NamingScheme : byte
{
    Suffix = 0,
    /// <summary>
    /// we use secondary and primary prefix as a prefix
    /// </summary>
    SecondaryPrefix = 1,
    PrimaryPrefix = 2,
}