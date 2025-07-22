namespace Free.Schema;

public enum BindField : byte
{
    Unknown = 0,

    Visibility = 1,
    Opacity = 2,

    Width = 10,
    Height = 11,
    MinWidth = 12,
    MinHeight = 13,
    MaxWidth = 14,
    MaxHeight = 15,

    CornerRadiusLeft = 20,
    CornerRadiusTop = 21,
    CornerRadiusRight = 22,
    CornerRadiusBottom = 23,

    ThicknessLeft = 30,
    ThicknessTop = 31,
    ThicknessRight = 32,
    ThicknessBottom = 33,

    PaddingLeft = 40,
    PaddingTop = 41,
    PaddingRight = 42,
    PaddingBottom = 43,

    SpacingHorizontal = 44,
    SpacingVertical = 45,

    ParagraphSpacing = 50,
    ParagraphIndent = 51,
    LineHeight = 52,
    LetterSpacing = 53,
    FontFamily = 54,
    FontStyle = 55,
    FontSize = 56,
    FontVariations = 57,
    Text = 58,

    ComponentId = 100,
    InstanceVariant = 101,
    Hyperlink = 102,
}