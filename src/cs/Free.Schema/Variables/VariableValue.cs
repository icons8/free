namespace Free.Schema;

public sealed class ColorValue
{
    /// <summary>
    /// Color value.
    /// </summary>
    public Color Value { get; set; }
    
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid ValueId { get; set; }
}

public sealed class BoolValue
{
    /// <summary>
    /// Boolean value.
    /// </summary>
    public bool Value { get; set; }
    
    /// <summary>
    /// Boolean variable ID.
    /// </summary>
    public Guid ValueId { get; set; }
}

public sealed class FloatValue
{
    /// <summary>
    /// Float value.
    /// </summary>
    public float Value { get; set; }
    
    /// <summary>
    /// Float variable ID.
    /// </summary>
    public Guid ValueId { get; set; }
}

public sealed class StringValue
{
    /// <summary>
    /// String value.
    /// </summary>
    public string Value { get; set; }
    
    /// <summary>
    /// String variable ID.
    /// </summary>
    public Guid ValueId { get; set; }
}