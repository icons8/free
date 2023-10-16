namespace Free.Schema;

[LunacySpecific]
public enum BackgroundRemovalState : byte
{
    None = 0,
    InProgress = 1,
    Done = 2,
    Failed = 3,
}