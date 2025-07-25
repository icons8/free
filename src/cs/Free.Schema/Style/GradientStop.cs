﻿namespace Free.Schema;
 
/// <summary>
/// A position-color pair representing a gradient stop.
/// </summary>
public sealed class GradientStop
{
    /// <summary>
    /// Value between 0 and 1 representing a position along gradient axis.
    /// </summary>
    public float Pos { get; set; }

    /// <summary>
    /// Color attached to a corresponding position.
    /// </summary>
    public Color Color { get; set; }
    
    /// <summary>
    /// Color variable ID.
    /// </summary>
    public Guid? ColorId { get; set; }
}