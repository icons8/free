namespace Free.Schema;

public class EffectStyle : StyleBase
{
    /// <summary>
    /// List of shadows of the style.
    /// </summary>
    public List<ShadowEffect> Shadows { get; } = new();
    /// <summary>
    /// List of inner shadows of the style.
    /// </summary>
    public List<ShadowEffect> InnerShadows { get; } = new();
    /// <summary>
    /// Definition of the blur effect of the style.
    /// </summary>
    public BlurEffect Blur { get; } = new();
}