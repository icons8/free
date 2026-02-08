using Free.Schema;

namespace Free.Scripts;

public static class LlmFilter
{
    private static readonly string[] ExcludedTypes = [
        "ComponentType", "Override", 
        
        "Document", "Connector", "Slice", "Meta", "SharedLibrary", "Font", "Page", "Rulers", 
        
        "LayoutGuideBase", "Rows", "Columns", "Grid", "GuideStyle", "LayoutHorizontalAlignment", "LayoutVerticalAlignment",
        
        "Flow", "FlowAnimation", "FlowAnimationType", "FlowAnimationEffect", "FlowAnimationDirection", "FlowOverlayPosition", "FlowScrollBehavior",
        "FlowTrigger", "MouseUpTrigger", "MouseLeaveTrigger", "MouseEnterTrigger", "MouseDownTrigger", "KeyPressTrigger",
        "HoverTrigger", "HoldTrigger", "DragTrigger", "ClickTrigger", "AfterDelayTrigger",
        "FlowAction", "SwitchStateAction", "SwapOverlayAction", "ScrollToAction", "OpenUrlAction", "OpenOverlayAction", 
        "NavigateToAction", "CloseOverlayAction", "BackAction", "Spring", "FlowScrollOverflow",
        
        "ComponentPropertyBase", "TextComponentProperty", "SwapComponentProperty", "StateComponentProperty", "BoolComponentProperty",
        
        "Expression", "ExpressionFunction", "Bind", "BindField", 
        
        "VariableTheme", "VariableCollection", "Variable", "StringValue", "FloatValue", "ColorValue", "BoolValue", 
        "StringVariable", "FloatVariable", "ColorVariable", "BoolVariable", "ThemeSelection",
    
        "ImageFilters", "BaselinePosition", "BlendMode", "Rect", "Color",
        
        "StyleBase", "ColorStyle", "TextStyle", "EffectStyle"
    ];

    private static readonly string[] ExcludedFields = [
        "MiterLimit", "Kerning", "IsTemplate", "Expand", "Trim", "KeepScroll",
        "Custom", "ImageFilters", "FigmaId", "StrokesIncluded", "ReverseZIndex",
        "Predefined",
        
        "FillsId", "BordersId", "EffectsId", "TextStyleId", "GridsId"
    ];

    private static readonly Type[] LlmTypeFilter = [
        typeof(List<Flow>), typeof(List<VariableCollection>), typeof(List<Variable>), typeof(List<ThemeSelection>), 
        typeof(List<Override>), typeof(List<LayoutGuideBase>)
    ];

    public static readonly string[] ObviousDescriptionObjects = [
        "VerticalAlignment", "HorizontalAlignment", 
        "TextVerticalAlignment", "TextHorizontalAlignment",
        "ScaleType", "MaskType", "ListMarkerType", "LineCap", "LineJoin",
        "GradientType", "FillType", "BlurType", "Arrowhead", 
        "Point", "Size", "ShadowEffect", "Gradient", "Fill", "ExportOption",
        "BlurEffect", "AutoLayout", "Layer", "Text", "Group", "Triangle",
        "Star", "Rectangle", "Polygon", "Oval", "Line"
    ];
    
    public static List<Node> FilterItemsForLlm(List<Node> items) => items
        .Where(x => !ExcludedTypes.Contains(x.Name))
        .Select(x =>
        {
            if (x.Type != NodeType.Enum)
            {
                foreach (var c in x.Childs)
                {
                    if (c.ValueType == typeof(Color))
                    {
                        c.ValueType = typeof(string);
                    }
                }
                foreach (var toRemove in x.Childs
                             .Where(c => ExcludedTypes.Contains(c.ValueType.Name) || 
                                         LlmTypeFilter.Contains(c.ValueType) ||
                                         ExcludedFields.Contains(c.Name))
                             .ToArray())
                {
                    x.Childs.Remove(toRemove);
                }
            }
            return x;
        })
        .ToList();
}