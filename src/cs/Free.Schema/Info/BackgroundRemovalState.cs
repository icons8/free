namespace Free.Schema;

/// <summary>
/// Background removal procedure info.
/// </summary>
[LunacySpecific]
public enum BackgroundRemovalState : byte
{
    None = 0,
    InProgress = 1,
    Done = 2,
    Failed = 3,
}