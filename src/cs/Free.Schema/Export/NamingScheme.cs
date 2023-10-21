namespace Free.Schema;

/// <summary>
/// Controls the use of suffixes/prefixes in export file names.
/// </summary>
[SketchCompatibility]
public enum NamingScheme : byte
{
    /// <summary>
    /// Indicates that the file name comes with a user-defined suffix.
    /// </summary>
    Suffix = 0,
    /// <summary>
    /// Indicates that the file name comes with a user-defined prefix.
    /// </summary>
    SecondaryPrefix = 1,

    /// <summary>
    /// Indicates that the file name comes with a user-defined prefix.
    /// </summary>
    PrimaryPrefix = 2,
}