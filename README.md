# Free Format

Open Source Format for a Vector Design Graphics designed to be compact, human-readable, back-compatible and optimised for multithreaded parsing.

## Base Types

Free format is NULL-free, NaN-free and Infinity-free - if any of this values are in JSON - it's broken. 

* <a name="float"></a>float - 32bit single-precision floating-point number
* <a name="int"></a>int - 32bit signed integer
* <a name="byte"></a>byte - 8-bit unsigned integer
* <a name="bool"></a>bool - Boolean (true or false) value
* <a name="string"></a>string - text as a sequence of UTF-8 code units
* <a name="GUID"></a>GUID - globally unique identifier, with base64 encryption

## Layers

### <a name="Component"></a>Component
A component is a reusable groups of layers.

Has all properties of [`Frame`](#Frame), plus:

* ComponentId: [GUID](#GUID) - Unique component identifier.
* Predefined: [bool](#bool) = `False` - Indicates that the component belongs to the Lunacy default component library (see the Component Tool on the Toolbar)
* ComponentType: [ComponentType](#ComponentType) = `None` - Reserved for future use. Will be used for components filters.
* _t: [string](#string) = `COMPONENT`

<details>
<summary>Sketch compatibility</summary>

* BackgroundInInstance: [bool](#bool) = `False` - Defines whether to include background in component instances.
</details>

### <a name="Oval"></a>Oval
An oval is a shape drawn on the canvas with the Oval tool.

Has all properties of [`Path`](#Path), plus:

* Angle: [float](#float) = `0` - End angle for donuts measured clockwise from the X axis.
* Ratio: [float](#float) = `0` - Inner radius for donuts.
* StartAngle: [float](#float) = `0` - Start angle for donuts measured clockwise from the X axis.
* _t: [string](#string) = `OVAL`

### <a name="Polygon"></a>Polygon
A polygon is a shape drawn on the canvas with the Polygon tool.

Has all properties of [`Path`](#Path), plus:

* Rays: [float](#float) = `0` - Defines the number of corners.
* _t: [string](#string) = `POLYGON`

### <a name="Rectangle"></a>Rectangle
A rectangle is a shape drawn on the canvas with the Rectangle tool.

Has all properties of [`Path`](#Path), plus:

* _t: [string](#string) = `RECT`

### <a name="Star"></a>Star
A star is a shape drawn on the canvas with the Star tool.

Has all properties of [`Path`](#Path), plus:

* Rays: [float](#float) = `0` - Defines the number of rays in a star.
* Ratio: [float](#float) = `0` - Defines the star ratio value.
* _t: [string](#string) = `STAR`

### <a name="Triangle"></a>Triangle
A triangle is a shape drawn on the canvas with the Triangle tool.

Has all properties of [`Path`](#Path), plus:

* _t: [string](#string) = `TRIANGLE`
* Equilateral: [bool](#bool) = `False`

### <a name="Frame"></a>Frame
A frame is a special type of layers that serves as a container for other layers or layer groups. Frames are a must for prototypes.

Has all properties of [`Styled`](#Styled), plus:

* CornerRadius: [float[]](#float) = `float[4]` - Sets the corner radius of the frame.
* SmoothCorners: [bool](#bool) = `False` - Enables smooth rounded corners like in iOS interfaces.
* ClipContent: [bool](#bool) = `False` - When enabled, hides the content outside the frame boundaries.
* FlowHome: [bool](#bool) = `False` - Sets the frame as a prototype starting point.
* Viewport: [PrototypeViewport](#PrototypeViewport) - Defines the area that should be displayed on a prototype, if the frame is resized to ensure scrolling effect.
* ResizesContent: [bool](#bool) = `False` - Enables adjusting and resizing the frame content as the frame is resized.
* Layouts: [IGridLayout[]](#IGridLayout) - ????????
* Rulers: [Rulers](#Rulers) - ?????????????
* Layers: [Layer[]](#Layer) - List of layers on the frame.
* _t: [string](#string) = `FRAME`

<details>
<summary>Sketch compatibility</summary>

* OverlayStyle: [Style](#Style) - Style settings for the frame if it acts an overlay in Sketch prototyping. For compatibility with Sketch only.
* GroupLayout: [IGroupLayout](#IGroupLayout) - Sketch Layout settings. Not supported in Lunacy, but keeping data for compatibility.
* BackgroundInExport: [bool](#bool) = `False` - When enabled, the frame background is included into export files.
* OverlayInteraction: [OverlayBackgroundInteraction](#OverlayBackgroundInteraction) = `None` - Overlay interaction for Sketch prototyping.
* Overlay: [bool](#bool) = `False` - Defines whether the frame acts as an overlay in prototyping.
* HasBackground: [bool](#bool) = `False` - Defines whether the frame has background.
* Background: [Color](#Color) = `ffffffff` - Defines the frame background color.
* BackgroundId: [GUID](#GUID) - Defines the background color variable ID.
* OverlaySettings: [OverlaySettings](#OverlaySettings) - Sketch prototyping overlay feature settings.
</details>

### <a name="Group"></a>Group
A layer group is two and more layers unified into a single entity that can be manipulated, organized, and treated as a single layer.

Has all properties of [`Styled`](#Styled), plus:

* SkipSelect: [bool](#bool) = `False` - When enabled, users can select group items without first selecting the group.
* Layers: [Layer[]](#Layer) - List of layers within the group.
* _t: [string](#string) = `GROUP`

<details>
<summary>Sketch compatibility</summary>

* SkipConstraints: [bool](#bool) = `False` - Serves for constraints compatibility with Sketch. If the file is imported from the Sketch format, the parameter should be set to false to handle constraints properly.
* GroupLayout: [IGroupLayout](#IGroupLayout) - Sketch group layout. We don't support it but keep it for compatibility
</details>

### <a name="Instance"></a>Instance
An instance is a copy of the main component. With instances, you can reuse the same design element in multiple places in your project while retaining a connection to the main component.

Has all properties of [`Styled`](#Styled), plus:

* CornerRadius: [float[]](#float) = `float[4]` - Sets the corner radius of the instance frame.
* SmoothCorners: [bool](#bool) = `False` - Enables smooth rounded corners like in iOS interfaces.
* Scale: [float](#float) = `0` - Scale of the instance.
* ComponentId: [GUID](#GUID) - Unique component identifier.
* Overrides: [Override[]](#Override) - Defines the overrides applied to the instance.
* _t: [string](#string) = `INSTANCE`

<details>
<summary>Sketch compatibility</summary>

* VerticalSpacing: [float](#float) = `0` - Defines vertical spacing.
* HorizontalSpacing: [float](#float) = `0` - Defines horizontal spacing.
</details>

### <a name="Path"></a>Path
A vector path determines the outline and form of a vector object. A path is made up of points and segments.

Has all properties of [`Styled`](#Styled), plus:

* Edited: [bool](#bool) = `False` - ???????
* Open: [bool](#bool) = `False` - Indicates whether the path is open.
* Points: [Vertex[]](#Vertex) - List of path's points.
* SmoothCorners: [bool](#bool) = `False` - Why is it here???? Paths have corner radius, but don't have the smooth corner option???????
* _t: [string](#string) = `PATH`

### <a name="Shape"></a>Shape
A shape is a rectangle, oval, polygon, triangle, or star drawn with the respective shape tool. You can draw a triangle, rectangle, etc. with the Pen tool, but they won't be treated as shapes.

Has all properties of [`Styled`](#Styled), plus:

* Layers: [Layer[]](#Layer) - List of layers.
* _t: [string](#string) = `SHAPE`

<details>
<summary>Sketch compatibility</summary>

* SkipConstraints: [bool](#bool) = `False` - Serves for constraints compatibility with Sketch. If the file is imported from the Sketch format, the parameter should be set to false to handle constraints properly.
* GroupLayout: [IGroupLayout](#IGroupLayout) - Sketch group layout. We don't support it, but keep it for compatibility.
</details>

### <a name="Text"></a>Text

Has all properties of [`Styled`](#Styled), plus:

* ClipContent: [bool](#bool) = `True` - after import from figma
* _t: [string](#string) = `TEXT`
* text: [string](#string)
* TextStyle: [TextStyle](#TextStyle)
* Inlines: [InlineStyle[]](#InlineStyle)
* DrawOnPath: [bool](#bool) = `False`
* StopSync: [bool](#bool) = `False`
* Behavior: [TextBehavior](#TextBehavior) = `Flexible`

### <a name="Hotspot"></a>Hotspot
A hotspot is a special type of layers used to define clickable areas on prototypes.

Has all properties of [`Layer`](#Layer), plus:

* _t: [string](#string) = `HOTSPOT`

### <a name="Slice"></a>Slice
A slice is a special type of layers used for exporting certaing parts of designs.

Has all properties of [`Layer`](#Layer), plus:

* HasBackground: [bool](#bool) = `False` - Defines whether the slice includes background.
* Background: [Color](#Color) = `00000000` - Defines the background color.
* BackgroundId: [GUID?](#GUID) - Unique color variable ID.
* _t: [string](#string) = `SLICE`

### <a name="Styled"></a>Styled

Has all properties of [`Layer`](#Layer), plus:

* StyleId: [GUID](#GUID)
* MiterLimit: [int](#int) = `10`
* Opacity: [float](#float) = `1`
* BlendMode: [BlendMode](#BlendMode) = `Normal`
* StartMarker: [Arrowhead](#Arrowhead) = `None`
* EndMarker: [Arrowhead](#Arrowhead) = `None`
* Winding: [PathFillType](#PathFillType) = `EvenOdd`
* Fills: [Fill[]](#Fill)
* Borders: [Border[]](#Border)
* Shadows: [ShadowEffect[]](#ShadowEffect)
* InnerShadows: [ShadowEffect[]](#ShadowEffect)
* Blur: [BlurEffect](#BlurEffect)
* BorderOptions: [BorderOptions](#BorderOptions)
* ImageFilters: [ImageFilters](#ImageFilters)

### <a name="Layer"></a>Layer
A layer is any ungrouped element available on the canvas.

* Id: [GUID](#GUID) - Unique layer identifier.
* NameIsFixed: [bool](#bool) = `False` - ??????
* BooleanOp: [BoolOp](#BoolOp) = `Union` - Defines the boolean operation applied to the layer.
* Fixed: [bool](#bool) = `False` - ???????
* Locked: [bool](#bool) = `False` - Defines whether the layer is locked.
* Hidden: [bool](#bool) = `False` - Defines whether the layer is hidden.
* IsTemplate: [bool](#bool) = `False` - Defines whether tha layer is marked as a template.
* Expand: [bool](#bool) = `False` - Defines whether the layer is expanded in Layer List.??????? But that's a layer, not a group???
* Transform: [Matrix](#Matrix) = `Free.Schema.Matrix` - ???????????
* Size: [Size](#Size) = `[100,100]` - Defines the layer size.
* LockAspect: [bool](#bool) = `False` - Defines whether the layer's aspect ratio should be remain unchanged upon resizing.
* Mask: [bool](#bool) = `False` - Defines whether the layer is used as a mask.
* BreakMask: [bool](#bool) = `False` - Defines if the layer is set to ignore the mask.
* KeepScroll: [bool](#bool) = `False` - If the Fix position on scroll option is enabled (prototyping).
* Animation: [AnimationType](#AnimationType) = `FromRight` - Defines the animation type (prototyping).
* MinWidth: [float](#float) = `0` - Defines the minimum layer width (auto layout).
* MinHeight: [float](#float) = `0` - Defines the minimum layer height (auto layout).
* MaxWidth: [float](#float) = `0` - Defines the maximum layer width (auto layout).
* MaxHeight: [float](#float) = `0` - Defines the maximum layer height (auto layout).
* LayoutStretch: [bool](#bool) = `False` - ???????
* LayoutGrowStretch: [bool](#bool) = `False` - ???????????
* LayoutFixPos: [bool](#bool) = `False` - Enables absolute position for the layer (auto layout).

<details>
<summary>Lunacy specific</summary>

* PhotoId: [string](#string) - Identifier of a photo from the Lunacy gallery.
* IllustrationId: [string](#string) - Identifier of an illustraion from the Lunacy gallery.
* IconId: [string](#string) - Identifier of an icon from the Lunacy gallery.
* AvatarId: [string](#string) - Identifier of a Lunacy-generated avatar.
* Data: [DataInfo](#DataInfo) - Information about auto generated texts.
* Upscaled: [bool](#bool) = `False` - If the image has been upscaled in Lunacy.
* BackgroundRemove: [BackgroundRemovalState](#BackgroundRemovalState) = `None` - Background removal procedure info.
</details>

### <a name="Border"></a>Border

Has all properties of [`Fill`](#Fill), plus:

* Thickness: [Thickness](#Thickness) = `[0,0,0,0]`
* Pos: [BorderPosition](#BorderPosition) = `Center`

### <a name="ColorAsset"></a>ColorAsset
Colors stored in the document (color picker > dropdown list (global) > document).

Has all properties of [`DocumentAssetBase`](#DocumentAssetBase), plus:

* Color: [Color](#Color) = `00000000`

### <a name="ColorVariable"></a>ColorVariable
Color variables stored in the document.

Has all properties of [`DocumentAssetBase`](#DocumentAssetBase), plus:

* Id: [GUID](#GUID) - Variable ID.
* Name: [string](#string) - Variable name.
* Value: [Color](#Color) = `00000000` - Color value of the variable.

### <a name="GradientAsset"></a>GradientAsset
Gradients stored in the document (color picker > dropdown list (global) > document).

Has all properties of [`DocumentAssetBase`](#DocumentAssetBase), plus:

* Value: [Gradient](#Gradient) - Values of gradients.

### <a name="AutoLayoutContainer"></a>AutoLayoutContainer

* Orientation: [LayoutOrientation](#LayoutOrientation) = `Horizontal`
* Spacing: [float](#float) = `0`
* WrapSpacing: [float](#float) = `0`
* Padding: [Thickness](#Thickness) = `[0,0,0,0]`
* Align: [HorizontalAlignment](#HorizontalAlignment) = `Left`
* Valign: [VerticalAlignment](#VerticalAlignment) = `Top`
* Sizing: [SizingMode](#SizingMode) = `Auto`
* Vsizing: [SizingMode](#SizingMode) = `Auto`
* TextBaseline: [bool](#bool) = `False`
* StrokesIncluded: [bool](#bool) = `False`
* ReverseZIndex: [bool](#bool) = `False`
* Wrap: [bool](#bool) = `False`
* WrapDistribute: [bool](#bool) = `False`

### <a name="BlurEffect"></a>BlurEffect

* Saturation: [float](#float) = `1`
* Radius: [float](#float) = `10`
* Enabled: [bool](#bool) = `False`
* Type: [BlurType](#BlurType) = `Gaussian`
* Center: [Point](#Point) = `[0,5,0,5]`
* MotionAngle: [float](#float) = `0`

### <a name="BorderOptions"></a>BorderOptions

* IsEnabled: [bool](#bool) = `False`
* LineCap: [LineCap](#LineCap) = `Butt`
* LineJoin: [LineJoin](#LineJoin) = `Miter`
* Dash: [float[]](#float)

### <a name="Columns"></a>Columns

* Enabled: [bool](#bool) = `False`
* Align: [LayoutHorizontalAlignment](#LayoutHorizontalAlignment) = `Left`
* Offset: [int](#int) = `0`
* Count: [int](#int) = `0`
* Gutter: [int](#int) = `0`
* Width: [int](#int) = `0`
* Color: [Color](#Color) = `00000000`

### <a name="Document"></a>Document
document.json structure

* Id: [GUID](#GUID) - Unique document ID.
* FromFigma: [bool](#bool) = `False` - The document is imported from Figma.
* Images: [string[]](#string) - Images stored in the document.
* Colors: [ColorAsset[]](#ColorAsset) - Colors stored in the document (color picker > dropdown list (global) > document).
* Gradients: [GradientAsset[]](#GradientAsset) - Gradients stored in the document (color picker > dropdown list (global) > document).
* Fonts: [Font[]](#Font) - Shared fonts stored in the document.
* ColorVariables: [ColorVariable[]](#ColorVariable) - Color variables stored in the document.
* LayerStyles: [SharedStyle[]](#SharedStyle) - Layer styles stored in the document.
* TextStyles: [SharedStyle[]](#SharedStyle) - Text styles stored in the document.
* Pages: [GUID[]](#GUID) - List of document pages.
* ColorSpace: [ColorSpace](#ColorSpace) = `Unmanaged`
* CurrentPageIndex: [int](#int) = `0`

### <a name="DocumentAssetBase"></a>DocumentAssetBase
??????????

* Id: [GUID](#GUID)
* Name: [string](#string)

### <a name="ExportFormat"></a>ExportFormat
Export settings.

* Size: [float](#float) = `0` - Defines the width/height of the exported object. Valid only when ScaleType is *Width* or *Height*.
* Format: [string](#string) = `png` - Export format. Default: PNG.
* Name: [string](#string) - User-defined suffix/preffix (string) added to the export file name. Default: empty.
* Naming: [NamingScheme](#NamingScheme) = `Suffix` - Defines whether a suffix or preffix will be added to the export files name. Default: suffix.
* Scale: [float](#float) = `0` - Defines the scale used when exporting an object. Valid only when ScaleType is set to *Scale*.
* Type: [ScaleType](#ScaleType) = `Scale` - Defines the scale type: Scale(px)/Width/Height. The Width and Height types are currently not supported.

### <a name="ExportOptions"></a>ExportOptions
Export options.

* Formats: [ExportFormat[]](#ExportFormat) - List of export formats set by the user.
* Trim: [bool](#bool) = `False` - When enabled, trims empty pixels in exported images.

### <a name="Fill"></a>Fill

* ColorId: [GUID?](#GUID) - Color Variable ID
* Enabled: [bool](#bool) = `False`
* Color: [Color](#Color) = `00000000`
* Type: [FillType](#FillType) = `Color`
* Opacity: [float](#float) = `0`
* BlendMode: [BlendMode](#BlendMode) = `Normal`
* Pattern: [Pattern](#Pattern)
* Gradient: [Gradient](#Gradient)

### <a name="Font"></a>Font
Shared fonts stored in the document. ??? embeded???

* Data: [string](#string) - ?????????
* Name: [string](#string) - Font name.
* FileName: [string](#string) - Font file name.
* PostscriptNames: [string[]](#string) - ??????

### <a name="Foreign"></a>Foreign
Defines entities from external libraries.

* ColorVariables: [ForeignColorVariable[]](#ForeignColorVariable) - Color variables from an external library.
* LayerStyles: [ForeignSharedStyle[]](#ForeignSharedStyle) - Layer styles from an external library.
* TextStyles: [ForeignSharedStyle[]](#ForeignSharedStyle) - Text styles from an external library.
* Components: [ForeignComponent[]](#ForeignComponent) - Components from an external library.

### <a name="ForeignColorVariable"></a>ForeignColorVariable
Describes color variables from external libraries.

* Id: [GUID](#GUID) - Unique variable identifier.
* LibraryId: [GUID](#GUID) - Unique library identifier.
* LibraryName: [string](#string) - Library name.
* Color: [ColorVariable](#ColorVariable) - Value of the color variable.

<details>
<summary>Sketch compatibility</summary>

* ComponentPrivate: [bool](#bool) = `False` - A Sketch flag for private shared color variables.
* RemoteId: [GUID](#GUID) - Color variable ID in the external library.
</details>

### <a name="ForeignComponent"></a>ForeignComponent
Describes color components from external libraries.

* Id: [GUID](#GUID) - Unique component identifier.
* LibraryId: [GUID](#GUID) - Unique library identifier.
* LibraryName: [string](#string) - Library name.
* Original: [Component](#Component) - Original state of the component upon import.
* Component: [Component](#Component) - Current state of the component.

<details>
<summary>Sketch compatibility</summary>

* ComponentPrivate: [bool](#bool) = `False` - A sketch flag for private shared components.
</details>

### <a name="ForeignSharedStyle"></a>ForeignSharedStyle
Describes styles from external libraries.

* LibraryId: [GUID](#GUID) - Unique library identifier.
* LibraryName: [string](#string) - Library name.
* RemoteID: [GUID](#GUID) - Style identifier in the external library.
* Id: [GUID](#GUID)

<details>
<summary>Sketch compatibility</summary>

* ComponentPrivate: [bool](#bool) = `False` - A sketch flag for private shared styles.
</details>

### <a name="Gradient"></a>Gradient
An object that represent a Gradient.

* Type: [GradientType](#GradientType) = `Linear` - The type of the Gradient.
* From: [Point](#Point) = `[0,5,0]` - The position of the start of the Gradient.
* To: [Point](#Point) = `[0,5,1]` - The position of the end of the Gradient.
* Side: [Point](#Point) = `[0,0]` - The position of the side point of the Gradient. Used for Radial and Angular Gragients
* Stops: [GradientStop[]](#GradientStop) - The different stops of the Gradient.

### <a name="GradientStop"></a>GradientStop
A position color pair representing a gradient stop.

* Pos: [float](#float) = `0` - Value between 0 and 1 representing position along gradient axis.
* Color: [Color](#Color) = `ffffffff` - Color attached to corresponding position.

### <a name="Grid"></a>Grid

* Enabled: [bool](#bool) = `False`
* Color: [Color](#Color) = `00000000`
* Size: [int](#int) = `10`

<details>
<summary>Sketch compatibility</summary>

* ThickTimes: [int](#int) = `10`
</details>

### <a name="ImageFilters"></a>ImageFilters

* Enabled: [bool](#bool) = `False`
* Brightness: [float](#float) = `0`
* Contrast: [float](#float) = `1`
* Hue: [float](#float) = `0`
* Saturation: [float](#float) = `1`

### <a name="InlineStyle"></a>InlineStyle
Style of text part

* Start: [int](#int) = `0` - selection start position
* Length: [int](#int) = `0` - length of selection
* Style: [TextStyle](#TextStyle) - Selection style

### <a name="Meta"></a>Meta
Contains metadata about the document

* Version: [int](#int) = `0` - Free Format Version
* App: [string](#string) - App Name
* Variant: [string](#string) - App Variant - (beta/standalone/store/web/etc.)
* AppVersion: [string](#string) - App Version

### <a name="Override"></a>Override

* ComponentId: [GUID?](#GUID)
* Export: [ExportOptions](#ExportOptions)
* Image: [string](#string)
* Link: [string](#string)
* Locked: [bool?](#bool)
* Hidden: [bool?](#bool)
* ClipContent: [bool?](#bool)
* LockAspect: [bool?](#bool)
* Ratio: [float?](#float)
* VertexCount: [float?](#float)
* ArcAngle: [float?](#float)
* ArcRatio: [float?](#float)
* ArcStartAngle: [float?](#float)
* CornerRadius: [float[]](#float)
* SmoothCorners: [bool](#bool) = `False`
* TextStyleId: [GUID?](#GUID)
* LayerStyleId: [GUID?](#GUID)
* StyleId: [GUID?](#GUID)
* Tint: [Color?](#Color)
* TintId: [GUID?](#GUID)
* BorderOptions: [BorderOptions](#BorderOptions)
* Blur: [BlurEffect](#BlurEffect)
* ImageFilters: [ImageFilters](#ImageFilters)
* Opacity: [float?](#float)
* BlendMode: [BlendMode?](#BlendMode)
* StartArrowhead: [Arrowhead?](#Arrowhead)
* EndArrowhead: [Arrowhead?](#Arrowhead)
* Text: [string](#string)
* TextStyle: [TextStyle](#TextStyle)
* TextBehavior: [TextBehavior?](#TextBehavior)
* Size: [Size?](#Size)
* Orientation: [LayoutOrientation?](#LayoutOrientation)
* Spacing: [float?](#float)
* WrapSpacing: [float?](#float)
* MinWidth: [float?](#float)
* MinHeight: [float?](#float)
* MaxWidth: [float?](#float)
* MaxHeight: [float?](#float)
* Padding: [Thickness?](#Thickness)
* Align: [HorizontalAlignment?](#HorizontalAlignment)
* VAlign: [VerticalAlignment?](#VerticalAlignment)
* Sizing: [SizingMode?](#SizingMode)
* VSizing: [SizingMode?](#SizingMode)
* TextBaseline: [bool?](#bool)
* StrokesIncluded: [bool?](#bool)
* ReverseZIndex: [bool?](#bool)
* Stretch: [bool?](#bool)
* GrowStretch: [bool?](#bool)
* Wrap: [bool?](#bool)
* WrapDistribute: [bool?](#bool)

<details>
<summary>Sketch compatibility</summary>

* LegacyColor: [ColorOverride](#ColorOverride)
* LegacyTextColor: [TextColorOverride](#TextColorOverride)
* LegacyTextWeight: [TextWeightOverride](#TextWeightOverride)
</details>

### <a name="Page"></a>Page
Document page properties.

* Id: [GUID](#GUID) - Unique page ID.
* Name: [string](#string) - Page name.
* Background: [Color](#Color) = `00000000` - Canvas color.
* IsComponentPage: [bool](#bool) = `False` - If the page is used to store components.
* Rulers: [Rulers](#Rulers) - Rulers applied by the user.
* Origin: [Point](#Point) = `[0,0]` - Point where the user left off the page.
* Zoom: [float](#float) = `0` - Zoom scale last applied to the page.
* Layers: [Layer[]](#Layer) - List of layers in the page.

### <a name="Pattern"></a>Pattern

* Rotation: [float](#float) = `0` - For all fill types except crop
* TileScale: [float](#float) = `1` - Used only for Tile
* Transform: [Matrix?](#Matrix) - Only used in Crop pattern fill type
* Type: [PatternFillType](#PatternFillType) = `Fill`
* Image: [string](#string)

### <a name="PrototypeViewport"></a>PrototypeViewport

* Name: [string](#string)
* Size: [Size](#Size) = `[0,0]`
* LibraryId: [GUID](#GUID)
* TemplateId: [GUID](#GUID)

### <a name="Rows"></a>Rows

* Enabled: [bool](#bool) = `False`
* Align: [LayoutVerticalAlignment](#LayoutVerticalAlignment) = `Top`
* Offset: [int](#int) = `0`
* Count: [int](#int) = `0`
* Gutter: [int](#int) = `0`
* Width: [int](#int) = `0`
* Color: [Color](#Color) = `00000000`

### <a name="Rulers"></a>Rulers
Object containing rulers origin and guidelines positions

* Guides: [int[]](#int) - Vertical guidelines positions on Horizontal Ruler
* VGuides: [int[]](#int) - Horizontal guidelines positions on Vertical Ruler

<details>
<summary>Sketch compatibility</summary>

* Origin: [Point](#Point) = `[0,0]` - Origin for Rulers. Not supported in Lunacy. Sketch Compatibility
</details>

### <a name="ShadowEffect"></a>ShadowEffect

* ColorId: [GUID?](#GUID) - Color Variable ID
* Enabled: [bool](#bool) = `True`
* Radius: [float](#float) = `0`
* Color: [Color](#Color) = `00000000`
* Spread: [float](#float) = `0`
* Offset: [Point](#Point) = `[0,0]`
* Opacity: [float](#float) = `0`
* BlendMode: [BlendMode](#BlendMode) = `Normal`

### <a name="SharedStyle"></a>SharedStyle
Style saved in the document.

* Id: [GUID](#GUID) - Unique style ID.
* Name: [string](#string) - Style name.
* Style: [Style](#Style) - Layer style settings.

### <a name="Style"></a>Style

* MiterLimit: [int](#int) = `10`
* Opacity: [float](#float) = `1`
* BlendMode: [BlendMode](#BlendMode) = `Normal`
* StartMarker: [Arrowhead](#Arrowhead) = `None`
* EndMarker: [Arrowhead](#Arrowhead) = `None`
* Winding: [PathFillType](#PathFillType) = `EvenOdd`
* Fills: [Fill[]](#Fill)
* Borders: [Border[]](#Border)
* Shadows: [ShadowEffect[]](#ShadowEffect)
* InnerShadows: [ShadowEffect[]](#ShadowEffect)
* Blur: [BlurEffect](#BlurEffect)
* BorderOptions: [BorderOptions](#BorderOptions)
* ImageFilters: [ImageFilters](#ImageFilters)

### <a name="TextStyle"></a>TextStyle

* ColorId: [GUID?](#GUID) - Color Variable ID
* Color: [Color](#Color) = `ff000000`
* Font: [string](#string) = `Inter`
* Size: [float](#float) = `12`
* ParagraphSpacing: [float](#float) = `0`
* Kerning: [float](#float) = `0`
* BaselineOffset: [float](#float) = `0`
* LineHeight: [float?](#float)
* Casing: [CharacterCasing](#CharacterCasing) = `Normal`
* Align: [TextHorizontalAlignment](#TextHorizontalAlignment) = `Left`
* Valign: [TextVerticalAlignment](#TextVerticalAlignment) = `Top`
* List: [ListMarkerType](#ListMarkerType) = `None`
* RTL: [bool](#bool) = `False`
* Underline: [bool](#bool) = `False`
* Strikethrough: [bool](#bool) = `False`
* BaselinePos: [BaselinePosition](#BaselinePosition) = `Normal`

### <a name="IGridLayout"></a>IGridLayout

* Enabled: [bool](#bool) = `False`
* _t: [string](#string) = `COLS`

### <a name="ILayoutContainer"></a>ILayoutContainer

* _t: [string](#string) = `AUTO`

### <a name="Color"></a>Color Struct
32-bit ARGB unpremultiplied color value.

* Alpha: [byte](#byte) = `0` - Gets the alpha component of the color.
* Red: [byte](#byte) = `0` - Gets the red component of the color.
* Green: [byte](#byte) = `0` - Gets the green component of the color.
* Blue: [byte](#byte) = `0` - Gets the blue component of the color.

### <a name="Matrix"></a>Matrix Struct
A transformation matrix is standard way in computer graphics to represent translation and rotation.
            These are the top two rows of a 3x3 matrix. The bottom row of the matrix is assumed to be [0, 0, 1].
            This is known as an affine transform and is enough to represent translation, rotation, and skew.
            The identity transform is [1, 0, 0,   0, 1, 0].
            A translation matrix will typically look like: [1, 0, tx,   0, 1, ty]
            and a rotation matrix will typically look like: [cos(angle), -sin(angle), 0,   sin(angle), cos(angle), 0]
            If Matrix contains only translation it will be printed like point [0,5]

* ScaleX: [float](#float) - Scale by x-coord. Usually should be 1.
            If it's -1 - layer is flipped horizontally.
            If it's some random number - it's a cos(angle).
* SkewX: [float](#float) - Skew by x-coord. Usually should be 0.
            If it's some random number - it's a -sin(angle).
* TransX: [float](#float) - Translation by x-coord.
* SkewY: [float](#float) - Skew by y-coord. Usually should be 0.
            If it's some random number - it's a sin(angle).
* ScaleY: [float](#float) - Scale by y-coord. Usually should be 1.
            If it's -1 - layer is flipped vertically.
            If it's some random number - it's a cos(angle).
* TransY: [float](#float) - Translation by y-coord.

### <a name="Point"></a>Point Struct
A utility class to represent a point.

* X: [float](#float) - The x coordinate of the point.
* Y: [float](#float) - The y coordinate of the point.

### <a name="Rect"></a>Rect Struct
A utility class to represent a rectangle. Contains some methods to make interacting with a rectangle easier.

* Left: [float](#float) - A utility class to represent a rectangle. Contains some methods to make interacting with a rectangle easier.
* Top: [float](#float) - The x coordinate of the top-left corner of the rectangle. Or an object with
* Width: [float](#float) - The width of the rectangle.
* Height: [float](#float) - The height of the rectangle.

### <a name="Size"></a>Size Struct

### <a name="Thickness"></a>Thickness Struct

### <a name="Vertex"></a>Vertex Struct
!most critical moment in wiki doc. [x,y,flags,radius,fromX,fromY,toX,toY]

* Point: [Point](#Point) = `[0,0]` - Base Point of a Vertex
* From: [Point](#Point) = `[0,0]` - First Control Point, Curve From
* To: [Point](#Point) = `[0,0]` - Second Control Point, Curve To
* Radius: [float](#float) - Corner Radius of a vertex point. It's stored in half because we don't need that much precision for corner radius
* Flags: [VertexFlags](#VertexFlags) = `None` - Vertex flags, contains: CurveMode, hasFrom, hasTo and CornerStyle

### <a name="AnimationType"></a>AnimationType Enum

* `-1` None
* `0` FromRight
* `1` FromLeft
* `2` FromBottom
* `3` FromTop

### <a name="Arrowhead"></a>Arrowhead Enum

* `0` None
* `1` Arrow
* `2` ArrowFilled
* `3` Line
* `4` Circle
* `5` CircleFilled
* `6` Square
* `7` SquareFilled

### <a name="BaselinePosition"></a>BaselinePosition Enum

* `1` Superscript - small letter on top, like a^2
* `-1` Subscript - small letter on bottom
* `0` Normal

### <a name="BlendMode"></a>BlendMode Enum

* `0` Normal
* `1` Darken
* `2` Multiply
* `3` ColorBurn
* `4` Lighten
* `5` Screen
* `6` ColorDodge
* `7` Overlay
* `8` SoftLight
* `9` HardLight
* `10` Difference
* `11` Exclusion
* `12` Hue
* `13` Saturation
* `14` Color
* `15` Luminosity
* `16` PlusDarker
* `17` PlusLighter

### <a name="BlurType"></a>BlurType Enum

* `0` Gaussian
* `1` Motion
* `2` Zoom
* `3` Background

### <a name="BoolOp"></a>BoolOp Enum
The type of operation used to combine the children of this node.

* `-1` None - Not set. Works like Difference or like Union depends on context
* `0` Union - Combine
* `1` Subtract - Subtract one from another
* `2` Intersect - Get shapes intersection
* `3` Difference - Draw shapes difference

### <a name="BorderPosition"></a>BorderPosition Enum

* `0` Center
* `1` Inside
* `2` Outside

### <a name="CharacterCasing"></a>CharacterCasing Enum

* `0` Normal
* `1` UpperCase
* `2` LowerCase
* `3` TitleCase

### <a name="ComponentType"></a>ComponentType Enum
Type of component. Not all values are used now. This is only for components filtering usage for now.

* `0` None
* `10` Button
* `11` RadioButton
* `12` CheckBox
* `13` Toggle
* `14` ToggleButton
* `15` SpinButton
* `16` SplitButton
* `17` SpeedDial
* `18` SocialButton
* `40` TextInput
* `41` TextArea
* `42` TextEditor
* `43` NumberInput
* `44` DateInput
* `45` TimeInput
* `46` DateTimeInput
* `47` PasswordInput
* `48` SearchBar
* `49` DropDownInput
* `70` DropDown
* `71` ProgressBar
* `72` Slider
* `73` Knob
* `74` Rating
* `75` ScrollBar
* `76` Paginator
* `77` Preloader
* `80` NavigationBar
* `81` StatusBar
* `82` ToolBar
* `83` SideBar
* `90` MenuBar
* `91` ContextMenu
* `92` MenuItem
* `100` Breadcrumbs
* `101` List
* `102` ListItem
* `103` Tree
* `104` TreeItem
* `105` TabStrip
* `106` TabItem
* `110` Table
* `111` TreeTable
* `112` TableHeader
* `113` TableRow
* `114` TableCell
* `120` Window
* `121` Dialog
* `122` Popup
* `123` ToolTip
* `124` Notification
* `125` Toast
* `126` Message
* `130` Avatar
* `131` Badge
* `132` Chip
* `133` Skeleton
* `134` Tag
* `135` Card
* `136` DropArea
* `137` Ad
* `140` Expander
* `141` Splitter
* `142` Carousel
* `143` GroupBox
* `150` Map
* `151` Browser
* `152` Calendar
* `153` ColorPicker
* `154` MediaPlayer
* `155` ImageGallery
* `156` Timeline
* `157` Graph
* `158` Diagram
* `159` SourceCode
* `160` Barcode
* `161` Gauge
* `162` Captcha
* `200` Keyboard
* `201` Cursor
* `202` DeviceFrame

### <a name="CurveMode"></a>CurveMode Enum

* `0` None
* `1` Straight
* `2` Mirrored
* `3` Asymmetric
* `4` Disconnected

### <a name="FillType"></a>FillType Enum

* `0` Color
* `1` Gradient
* `4` Pattern

### <a name="GradientType"></a>GradientType Enum
Enumeration of the type of a Gradient.

* `0` Linear - Linear gradients tend to be the most common, where two colors will appear at opposite points of an object and will blend, or transition into each other.
* `1` Radial - A radial gradient will create an effect where the transition between color stops will be in a circular pattern.
* `2` Angular - This effect allows you to create gradients that sweep around the circumference (measured by the maximum width or height of a layer) in a clockwise direction.

### <a name="HorizontalAlignment"></a>HorizontalAlignment Enum

* `0` Left
* `1` Center
* `2` Right
* `3` Distribute

### <a name="LayoutHorizontalAlignment"></a>LayoutHorizontalAlignment Enum

* `0` Left
* `1` Center
* `2` Right
* `3` Stretch

### <a name="LayoutOrientation"></a>LayoutOrientation Enum

* `0` Horizontal
* `1` Vertical

### <a name="LayoutVerticalAlignment"></a>LayoutVerticalAlignment Enum

* `0` Top
* `1` Middle
* `2` Bottom
* `3` Stretch

### <a name="LineCap"></a>LineCap Enum
Enumeration of the positions of a border.

* `0` Butt - This is the default option that’ll draw the border right to the vector point.
* `1` Round - Creates a rounded, semi-circular end to a path that extends past the vector point.
* `2` Square - Similar to the rounded cap, but with a straight edges.

### <a name="LineJoin"></a>LineJoin Enum

* `0` Miter
* `1` Round
* `2` Bevel

### <a name="ListMarkerType"></a>ListMarkerType Enum

* `0` None
* `1` Bullet
* `2` Numbered

### <a name="PathFillType"></a>PathFillType Enum

* `0` Winding - Specifies that "inside" is computed by a non-zero sum of signed edge crossings.
* `1` EvenOdd - Specifies that "inside" is computed by an odd number of edge crossings.

### <a name="PatternFillType"></a>PatternFillType Enum

* `0` Tile
* `1` Fill
* `2` Stretch
* `3` Fit
* `4` Crop

### <a name="ScaleType"></a>ScaleType Enum
Defines the scale type for exported objects.

* `0` Scale
* `1` Width
* `2` Height

### <a name="SizingMode"></a>SizingMode Enum

* `0` Auto
* `1` Fixed

### <a name="TextBehavior"></a>TextBehavior Enum
Enumeration of the behaviours for text layers

* `1` AutoHeight - The width of the textbox is fixed. Characters wrap to fit in the textbox. The height of the textbox automatically adjusts to fit its content.
* `2` Fixed - The size of the textbox is fixed and is independent of its content.
* `0` Flexible

### <a name="TextHorizontalAlignment"></a>TextHorizontalAlignment Enum

* `0` Left
* `1` Right
* `2` Center
* `3` Justify

### <a name="TextVerticalAlignment"></a>TextVerticalAlignment Enum

* `0` Top
* `1` Middle
* `2` Bottom

### <a name="VertexFlags"></a>VertexFlags Enum

* `0` None
* `1` Mirrored
* `2` Asymmetric
* `3` Disconnected
* `4` HasCurveFrom
* `8` HasCurveTo

<details>
<summary>Sketch compatibility</summary>

* `16` RoundedInverted
* `32` Angled
* `48` Squared
</details>

### <a name="VerticalAlignment"></a>VerticalAlignment Enum

* `0` Top
* `1` Center
* `2` Bottom
* `3` Distribute

### <a name="DataInfo"></a>DataInfo
Information about auto generated texts. _//Lunacy Specific_

* Type: [DataType](#DataType) = `Unknown` - Category of generated text (person, address, date, etc.).
* Field: [DataFieldType](#DataFieldType) = `Unknown` - Type of generated text (full name or first name, city or ZIP code, etc.).
* Format: [string](#string) - String format for Data Type. Used for Date/Time values.

### <a name="BackgroundRemovalState"></a>BackgroundRemovalState Enum
Background removal procedure info. _//Lunacy Specific_

* `0` None
* `1` InProgress
* `2` Done
* `3` Failed

### <a name="DataFieldType"></a>DataFieldType Enum
Defines the type of generated text. _//Lunacy Specific_

* `0` Unknown
* `1` FullName
* `2` FirstName
* `3` LastName
* `4` Phone
* `5` Email
* `6` FullAddress
* `7` State
* `8` City
* `9` ZipCode
* `10` Theme
* `11` Header
* `12` Paragraph
* `13` Company
* `14` Department
* `15` JobTitle
* `16` Amount
* `17` CreditCard
* `18` Day
* `19` DayOfWeek
* `20` Year
* `21` Month
* `22` DateSlash
* `23` DateDot
* `24` DateFull
* `25` Time12
* `26` Time24
* `27` Country
* `28` Language
* `29` Url
* `30` UserName
* `31` FileName

### <a name="DataType"></a>DataType Enum
Defines the category of generated text. _//Lunacy Specific_

* `0` Unknown
* `1` Address
* `2` Article
* `3` Business
* `4` Country
* `5` Date
* `6` Language
* `7` Person
* `8` Technology
* `9` Time

### <a name="ColorOverride"></a>ColorOverride
 _//Sketch Compatibility_
* ColorId: [GUID?](#GUID) - Color Variable ID
* Color: [Color](#Color) = `00000000`
* Property: [ColorOverrideType](#ColorOverrideType) = `Unknown`
* Index: [int](#int) = `0`

### <a name="FreeFormGroupLayout"></a>FreeFormGroupLayout
 _//Sketch Compatibility_
### <a name="InferredGroupLayout"></a>InferredGroupLayout
 _//Sketch Compatibility_
* Axis: [GroupLayoutAxis](#GroupLayoutAxis) = `Horizontal`
* LayoutAnchor: [GroupLayoutAnchor](#GroupLayoutAnchor) = `Begin`
* MaxSize: [float](#float) = `0`
* MinSize: [float](#float) = `0`

### <a name="OverlaySettings"></a>OverlaySettings
 _//Sketch Compatibility_
* Offset: [Point](#Point) = `[0,0]`
* OverlayAnchor: [Point](#Point) = `[0,0]`
* OverlayType: [OverlayType](#OverlayType) = `0`
* SourceAnchor: [Point](#Point) = `[0,0]`

### <a name="TextColorOverride"></a>TextColorOverride
 _//Sketch Compatibility_
* ColorId: [GUID?](#GUID) - Color Variable ID
* Color: [Color](#Color) = `00000000`

### <a name="TextWeightOverride"></a>TextWeightOverride
 _//Sketch Compatibility_
* Slant: [float](#float) = `0`
* Proportion: [float](#float) = `0`
* Symbolic: [float](#float) = `0`
* Weight: [float](#float) = `0`

### <a name="IGroupLayout"></a>IGroupLayout
 _//Sketch Compatibility_
### <a name="ColorOverrideType"></a>ColorOverrideType Enum
 _//Sketch Compatibility_
* `0` Unknown
* `1` Fill
* `2` Border
* `3` Shadow
* `4` InnerShadow

### <a name="ColorSpace"></a>ColorSpace Enum
Document color space (color scheme the document uses). _//Sketch Compatibility_

* `0` Unmanaged
* `1` sRGB
* `2` P3

### <a name="CornerStyle"></a>CornerStyle Enum
Sketch legacy, not supported in Lunacy _//Sketch Compatibility_

* `0` Rounded
* `1` RoundedInverted
* `2` Angled
* `3` Squared

### <a name="GroupLayoutAnchor"></a>GroupLayoutAnchor Enum
 _//Sketch Compatibility_
* `0` Begin
* `1` Middle
* `2` End

### <a name="GroupLayoutAxis"></a>GroupLayoutAxis Enum
 _//Sketch Compatibility_
* `0` Horizontal
* `1` Vertical

### <a name="NamingScheme"></a>NamingScheme Enum
Controls the use of suffixes/prefixes in export file names. _//Sketch Compatibility_

* `0` Suffix - Indicates that the file name comes with a user-defined suffix.
* `1` SecondaryPrefix - Indicates that the file name comes with a user-defined prefix.
* `2` PrimaryPrefix - Indicates that the file name comes with a user-defined prefix.

### <a name="OverlayBackgroundInteraction"></a>OverlayBackgroundInteraction Enum
 _//Sketch Compatibility_
* `0` None
* `1` CrossOverlay
* `2` AllowAll

### <a name="OverlayType"></a>OverlayType Enum
 _//Sketch Compatibility_
* `1` Screen
* `2` Layer


by Icons8 LLC 2023