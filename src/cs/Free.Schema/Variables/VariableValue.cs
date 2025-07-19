namespace Free.Schema;

/// <summary>
/// Value of a color variable.
/// </summary>
public sealed class ColorValue
{
    /// <summary>
    /// Theme unique identifier of a Value.
    /// </summary>
    public Guid ThemeId { get; set; }
    
    /// <summary>
    /// Color value.
    /// </summary>
    public Color Value { get; set; }
    
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid ValueId { get; set; }
}

/// <summary>
/// Value of a boolean variable.
/// </summary>
public sealed class BoolValue
{
    /// <summary>
    /// Theme unique identifier of a Value.
    /// </summary>
    public Guid ThemeId { get; set; }
    
    /// <summary>
    /// Boolean value.
    /// </summary>
    public bool Value { get; set; }
    
    /// <summary>
    /// Boolean variable ID.
    /// </summary>
    public Guid ValueId { get; set; }
}

/// <summary>
/// Value of a float variable
/// </summary>
public sealed class FloatValue
{
    /// <summary>
    /// Theme unique identifier of a Value.
    /// </summary>
    public Guid ThemeId { get; set; }
    
    /// <summary>
    /// Float value.
    /// </summary>
    public float Value { get; set; }
    
    /// <summary>
    /// Float variable ID.
    /// </summary>
    public Guid ValueId { get; set; }
}

/// <summary>
/// Value of a string variable
/// </summary>
public sealed class StringValue
{
    /// <summary>
    /// Theme unique identifier of a Value.
    /// </summary>
    public Guid ThemeId { get; set; }
    
    /// <summary>
    /// String value.
    /// </summary>
    public string? Value { get; set; }
    
    /// <summary>
    /// String variable ID.
    /// </summary>
    public Guid ValueId { get; set; }
}