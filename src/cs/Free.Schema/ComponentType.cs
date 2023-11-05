namespace Free.Schema;

/// <summary>
/// Types of components. Currently used for filtering only. Some of the types are not supported yet.
/// </summary>
public enum ComponentType : byte
{
    None = 0,
    
    Button = 10,
    RadioButton = 11,
    CheckBox = 12,
    Toggle = 13,
    ToggleButton = 14,
    SpinButton = 15,
    SplitButton = 16,
    SpeedDial = 17,
    SocialButton = 18,
    
    TextInput = 40,
    TextArea = 41,
    TextEditor = 42,
    NumberInput = 43,
    DateInput = 44,
    TimeInput = 45,
    DateTimeInput = 46,
    PasswordInput = 47,
    SearchBar = 48,
    DropDownInput = 49,
    
    DropDown = 70,
    ProgressBar = 71,
    Slider = 72,
    Knob = 73,
    Rating = 74,
    ScrollBar = 75,
    Paginator = 76,
    Preloader = 77,
    
    NavigationBar = 80,
    StatusBar = 81,
    ToolBar = 82,
    SideBar = 83,
    
    MenuBar = 90,
    ContextMenu = 91,
    MenuItem = 92,
    
    Breadcrumbs = 100,
    List = 101,
    ListItem = 102,
    Tree = 103,
    TreeItem = 104,
    TabStrip = 105,
    TabItem = 106,
    Table = 110,
    TreeTable = 111,
    TableHeader = 112,
    TableRow = 113,
    TableCell = 114,
    
    Window = 120,
    Dialog = 121,
    Popup = 122,
    ToolTip = 123,
    Notification = 124,
    Toast = 125,
    Message = 126,
    
    
    Avatar = 130,
    Badge = 131,
    Chip = 132,
    Skeleton = 133,
    Tag = 134,
    Card = 135,
    DropArea = 136,
    Ad = 137,
    
    Expander = 140,
    Splitter = 141,
    Carousel = 142,
    GroupBox = 143,

    Map = 150,
    Browser = 151,
    Calendar = 152,
    ColorPicker = 153,
    MediaPlayer = 154,
    ImageGallery = 155,
    Timeline = 156,
    Graph = 157,
    Diagram = 158,
    SourceCode = 159,
    Barcode = 160,
    Gauge = 161,
    Captcha = 162,
    
    
    Keyboard = 200,
    Cursor = 201,
    DeviceFrame = 202,
}