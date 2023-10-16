namespace Free.Schema;

/// <summary>
///about avatar layer
/// </summary>
[LunacySpecific]
public class AvatarInfo
{
    /// <summary>
    /// image id
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// is generated
    /// </summary>
    public bool Generated { get; set; }
}