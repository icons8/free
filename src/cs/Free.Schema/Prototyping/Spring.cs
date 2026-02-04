namespace Free.Schema;

/// <summary>
/// Spring animation parameters
/// </summary>
public struct Spring
{
    /// <summary>
    /// Spring Dumping, Min 0.01, Max=10000.
    /// </summary>
    public float Dumping { get; set; }
    /// <summary>
    /// Spring Mass, Min 0.01, Max=1000.
    /// </summary>
    public float Mass { get; set; }
    /// <summary>
    /// Spring Stiffness, Min=0.01, Max=1000000.
    /// </summary>
    public float Stiffness { get; set; }
}