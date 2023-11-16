namespace Free.Schema;

/// <summary>
/// Types of boolean operations used to combine shapes.
/// </summary>
public enum BoolOp : sbyte
{
    /// <summary>
    /// Not set. Works like Difference or like Union depending on the context.
    /// </summary>
    None = -1,
    /// <summary>
    /// Creates a shape from the sum of the areas of the selected shapes.
    /// </summary>
    Union = 0,
    /// <summary>
    /// The opposite of Union. Removes the overlapping area(s) from the shape layer at the bottom of the selection.
    /// </summary>
    Subtract = 1,
    /// <summary>
    /// The resulting shape only includes the area where all selected shapes overlap.
    /// </summary>
    Intersect = 2,
    /// <summary>
    /// The opposite of Intersect. Creates a shape from the areas where the selected shapes do not overlap.
    /// </summary>
    Difference = 3,
}