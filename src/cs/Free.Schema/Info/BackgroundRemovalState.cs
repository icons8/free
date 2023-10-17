namespace Free.Schema;

/// <summary>
/// background removal result
/// </summary>
[LunacySpecific]
public enum BackgroundRemovalState : byte
{
    None = 0,
    InProgress = 1,
    Done = 2,
    Failed = 3,
}