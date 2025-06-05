namespace Free.Schema;

public class GridLayoutStyle : StyleBase
{
    /// <summary>
    /// Grid, Row and Column layouts of the style.
    /// </summary>
    public List<GridLayoutBase> Layouts { get; } = new();
}