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

* ComponentId: [GUID](#GUID) - unique component identifier.
* Predefined: [bool](#bool) = `False` - indicates that the component belongs to the Lunacy default component library (see the Component Tool on the Toolbar)
* ComponentType: [ComponentType](#ComponentType) = `None` - reserved for future use. Will be used for components filters.
* _t: [string](#string) = `COMPONENT`

<details>
<summary>Sketch compatibility</summary>

* BackgroundInInstance: [bool](#bool) = `False` - defines whether to include background in component instances.
</details>

### <a name="Oval"></a>Oval
An oval is a shape drawn on the canvas with the Oval tool.

Has all properties of [`Path`](#Path), plus:

* Angle: [float](#float) = `0` - end angle for donuts measured clockwise from the X axis.
* Ratio: [float](#float) = `0` - inner radius for donuts.
* StartAngle: [float](#float) = `0` - start angle for donuts measured clockwise from the X axis.
* _t: [string](#string) = `OVAL`

### <a name="Polygon"></a>Polygon
A polygon is a shape drawn on the canvas with the Polygon tool.

Has all properties of [`Path`](#Path), plus:

* Rays: [float](#float) = `0` - defines the number of corners.
* _t: [string](#string) = `POLYGON`

### <a name="Rectangle"></a>Rectangle
A rectangle is a shape drawn on the canvas with the Rectangle tool.

Has all properties of [`Path`](#Path), plus:

* SmoothCorners: [bool](#bool) = `False` - if the smooth corners option is enabled. Works only if the rectangle is not edited.
* _t: [string](#string) = `RECT`

### <a name="Star"></a>Star
A star is a shape drawn on the canvas with the Star tool.

Has all properties of [`Path`](#Path), plus:

* Rays: [float](#float) = `0` - defines the number of rays in a star.
* Ratio: [float](#float) = `0` - defines the star ratio value.
* _t: [string](#string) = `STAR`

### <a name="Triangle"></a>Triangle
A triangle is a shape drawn on the canvas with the Triangle tool.

Has all properties of [`Path`](#Path), plus:

* _t: [string](#string) = `TRIANGLE`
* Equilateral: [bool](#bool) = `False`

### <a name="Frame"></a>Frame
A frame is a special type of layers that serves as a container for other layers or layer groups. Frames are a must for prototypes.

Has all properties of [`Styled`](#Styled), plus:

* CornerRadius: [float[]](#float) = `float[4]` - sets the corner radius of the frame.
* SmoothCorners: [bool](#bool) = `False` - enables smooth rounded corners like in iOS interfaces.
* ClipContent: [bool](#bool) = `False` - when enabled, hides the content outside the frame boundaries.
* FlowHome: [bool](#bool) = `False` - sets the frame as a prototype starting point.
* Viewport: [PrototypeViewport](#PrototypeViewport) - defines the area that should be displayed on a prototype, when the frame is resized to ensure scrolling effect.
* ResizesContent: [bool](#bool) = `False` - enables adjusting and resizing the frame content as the frame is resized.
* Layouts: [IGridLayout[]](#IGridLayout) - grid, Row and Column layouts of the frame.
* Rulers: [Rulers](#Rulers) - rulers and guidelines info.
* Layers: [Layer[]](#Layer) - list of layers on the frame.
* _t: [string](#string) = `FRAME`

<details>
<summary>Sketch compatibility</summary>

* OverlayStyle: [Style](#Style) - style settings for the frame if it acts as an overlay in Sketch prototyping.
* GroupLayout: [IGroupLayout](#IGroupLayout) - sketch Layout settings. Not supported in Lunacy, but keeping data for compatibility.
* BackgroundInExport: [bool](#bool) = `False` - when enabled, the frame background is included into export files.
* OverlayInteraction: [OverlayBackgroundInteraction](#OverlayBackgroundInteraction) = `None` - overlay interaction for Sketch prototyping.
* Overlay: [bool](#bool) = `False` - defines whether the frame acts as an overlay in prototyping.
* HasBackground: [bool](#bool) = `False` - defines whether the frame has background.
* Background: [Color](#Color) = `ffffffff` - defines the frame background color.
* BackgroundId: [GUID](#GUID) - defines the background color variable ID.
* OverlaySettings: [OverlaySettings](#OverlaySettings) - sketch prototyping overlay feature settings.
</details>

### <a name="Group"></a>Group
A layer group is two or more layers unified into a single entity that can be manipulated, organized, and treated as a single layer.

Has all properties of [`Styled`](#Styled), plus:

* SkipSelect: [bool](#bool) = `False` - when enabled, users can select group items without first selecting the group.
* Layers: [Layer[]](#Layer) - list of layers within the group.
* _t: [string](#string) = `GROUP`

<details>
<summary>Sketch compatibility</summary>

* SkipConstraints: [bool](#bool) = `False` - serves for constraints compatibility with Sketch. If the file is imported from the Sketch format, the parameter should be set to false to handle constraints properly.
* GroupLayout: [IGroupLayout](#IGroupLayout) - sketch group layout. We don't support it but keep it for compatibility
</details>

### <a name="Instance"></a>Instance
An instance is a copy of the main component. With instances, you can reuse the same design element in multiple places in your project while retaining a connection to the main component.

Has all properties of [`Styled`](#Styled), plus:

* CornerRadius: [float[]](#float) = `float[4]` - sets the corner radius of the instance frame.
* SmoothCorners: [bool](#bool) = `False` - enables smooth rounded corners like in iOS interfaces.
* Scale: [float](#float) = `0` - scale of the instance.
* ComponentId: [GUID](#GUID) - unique component identifier.
* Overrides: [Override[]](#Override) - defines the overrides applied to the instance.
* _t: [string](#string) = `INSTANCE`

<details>
<summary>Sketch compatibility</summary>

* VerticalSpacing: [float](#float) = `0` - defines vertical spacing.
* HorizontalSpacing: [float](#float) = `0` - defines horizontal spacing.
</details>

### <a name="Path"></a>Path
A vector path determines the outline and form of a vector object. A path is made up of points and segments.

Has all properties of [`Styled`](#Styled), plus:

* Edited: [bool](#bool) = `False` - if the shape is edited in the path editor.
* Open: [bool](#bool) = `False` - indicates whether the path is open.
* Points: [Vertex[]](#Vertex) - list of path's points.
* _t: [string](#string) = `PATH`

### <a name="Shape"></a>Shape
A shape is a rectangle, oval, polygon, triangle, or star drawn with the respective shape tool. You can draw a triangle, rectangle, etc. with the Pen tool, but they won't be treated as shapes.

Has all properties of [`Styled`](#Styled), plus:

* Layers: [Layer[]](#Layer) - list of layers.
* _t: [string](#string) = `SHAPE`

<details>
<summary>Sketch compatibility</summary>

* SkipConstraints: [bool](#bool) = `False` - serves for constraints compatibility with Sketch. If the file is imported from the Sketch format, the parameter should be set to false to handle constraints properly.
* GroupLayout: [IGroupLayout](#IGroupLayout) - sketch group layout. We don't support it, but keep it for compatibility.
</details>

### <a name="Text"></a>Text
Text is a block or line of text on the canvas.

Has all properties of [`Styled`](#Styled), plus:

* text: [string](#string) - content of the text layer.
* TextStyle: [TextStyle](#TextStyle) - style applied to the text.
* Inlines: [InlineStyle[]](#InlineStyle) - styling options applied to the text within a text block.
* Behavior: [TextBehavior](#TextBehavior) = `Flexible` - behavior of the text layer size on text value change: flexible, fixed-width, or fixed.
* ClipContent: [bool](#bool) = `True` - valid for files imported from Figma. Defines whether to truncate text content.
* _t: [string](#string) = `TEXT`

<details>
<summary>Sketch compatibility</summary>

* DrawOnPath: [bool](#bool) = `False` - this property enabled drawing text on path in Sketch.
</details>

### <a name="Hotspot"></a>Hotspot
A hotspot is a special type of layers used to define clickable areas on prototypes.

Has all properties of [`Layer`](#Layer), plus:

* _t: [string](#string) = `HOTSPOT`

### <a name="Slice"></a>Slice
A slice is a special type of layers used for exporting certaing parts of designs.

Has all properties of [`Layer`](#Layer), plus:

* HasBackground: [bool](#bool) = `False` - defines whether the slice includes background.
* Background: [Color](#Color) = `00000000` - defines the background color.
* BackgroundId: [GUID?](#GUID) - unique color variable ID.
* _t: [string](#string) = `SLICE`

### <a name="Styled"></a>Styled
A styled layer is a layer that has layer styling options.

Has all properties of [`Layer`](#Layer), plus:

* StyleId: [GUID](#GUID) - unique style identifier.
* MiterLimit: [int](#int) = `10` - limit on the ratio of the miter length to the stroke-width used to draw a miter joint. When the limit is exceeded, the joint is converted from miter to beveled.
* Opacity: [float](#float) = `1` - opacity value.
* BlendMode: [BlendMode](#BlendMode) = `Normal` - blend mode.
* StartMarker: [Arrowhead](#Arrowhead) = `None` - determines the appearance of the tail of an open path drawn with the Line, Arrow, or Pen/Pencil tool.
* EndMarker: [Arrowhead](#Arrowhead) = `None` - defines the appearance of the head of an open path drawn with the Line, Arrow, or Pen/Pencil tool.
* Winding: [PathFillType](#PathFillType) = `EvenOdd` - defines the filling options for overlapping paths.
* Fills: [Fill[]](#Fill) - list of fills.
* Borders: [Border[]](#Border) - list of borders.
* Shadows: [ShadowEffect[]](#ShadowEffect) - list of shadows.
* InnerShadows: [ShadowEffect[]](#ShadowEffect) - list of inner shadows.
* Blur: [BlurEffect](#BlurEffect) - information about blurs.
* BorderOptions: [BorderOptions](#BorderOptions) - information about border options.
* ImageFilters: [ImageFilters](#ImageFilters) - filters applied to an image (hue, saturartion, etc.), if any.

### <a name="Layer"></a>Layer
A layer is any ungrouped element available on the canvas.

* Id: [GUID](#GUID) - unique layer identifier.
* NameIsFixed: [bool](#bool) = `False` - name can be auto-generated or user-specified. User-specified fixed names will not be renamed after some operations.
* BooleanOp: [BoolOp](#BoolOp) = `Union` - defines the boolean operation applied to the layer.
* Fixed: [bool](#bool) = `False` - if enabled, the layer preserves its position when you scroll the screen of prototype (for instance, a floating button).
* Locked: [bool](#bool) = `False` - defines whether the layer is locked for editing.
* Hidden: [bool](#bool) = `False` - defines whether the layer is hidden.
* IsTemplate: [bool](#bool) = `False` - defines whether tha layer is marked as a template.
* Expand: [bool](#bool) = `False` - defines whether the layer is expanded in Layer List.
* Transform: [Matrix](#Matrix) = `Free.Schema.Matrix` - position, rotation and flips of an object, stored in a single 3x2 matrix.
* Size: [Size](#Size) = `[100,100]` - defines the layer size.
* LockAspect: [bool](#bool) = `False` - defines whether the layer's aspect ratio should be remain unchanged upon resizing.
* Mask: [bool](#bool) = `False` - defines whether the layer is used as a mask.
* BreakMask: [bool](#bool) = `False` - defines if the layer is set to ignore the mask.
* KeepScroll: [bool](#bool) = `False` - if the Fix position on scroll option is enabled (prototyping).
* Animation: [AnimationType](#AnimationType) = `FromRight` - defines the animation type (prototyping).
* MinWidth: [float](#float) = `0` - defines the minimum layer width (auto layout).
* MinHeight: [float](#float) = `0` - defines the minimum layer height (auto layout).
* MaxWidth: [float](#float) = `0` - defines the maximum layer width (auto layout).
* MaxHeight: [float](#float) = `0` - defines the maximum layer height (auto layout).
* LayoutStretch: [bool](#bool) = `False` - determines if the layer should stretch along the parent’s counter axis (auto layout).
* LayoutGrowStretch: [bool](#bool) = `False` - determines whether a layer should stretch along the parent’s primary axis (auto layout).
* LayoutFixPos: [bool](#bool) = `False` - enables absolute position for the layer (auto layout).

<details>
<summary>Lunacy specific</summary>

* PhotoId: [string](#string) - identifier of a photo from the Lunacy gallery.
* IllustrationId: [string](#string) - identifier of an illustraion from the Lunacy gallery.
* IconId: [string](#string) - identifier of an icon from the Lunacy gallery.
* AvatarId: [string](#string) - identifier of a Lunacy-generated avatar.
* Data: [DataInfo](#DataInfo) - information about auto generated texts.
* Upscaled: [bool](#bool) = `False` - if the image has been upscaled in Lunacy.
* BackgroundRemove: [BackgroundRemovalState](#BackgroundRemovalState) = `None` - background removal procedure info.
</details>

### <a name="Border"></a>Border
Defines the appearance of borders.

Has all properties of [`Fill`](#Fill), plus:

* Thickness: [Thickness](#Thickness) = `[0,0,0,0]` - defines border thickness.
* Pos: [BorderPosition](#BorderPosition) = `Center` - defines border position.

### <a name="AutoLayoutContainer"></a>AutoLayoutContainer
Defines auto layout settings.

* Orientation: [LayoutOrientation](#LayoutOrientation) = `Horizontal` - layout orientation: horizontal or vertical.
* Spacing: [float](#float) = `0` - spacing value
* Padding: [Thickness](#Thickness) = `[0,0,0,0]` - padding value.
* Align: [HorizontalAlignment](#HorizontalAlignment) = `Left` - horizontal alignment settings.???
* Valign: [VerticalAlignment](#VerticalAlignment) = `Top` - vertical alignment settings.???
* Sizing: [SizingMode](#SizingMode) = `Auto` - horizontal resizing mode: fixed or hug.???
* Vsizing: [SizingMode](#SizingMode) = `Auto` - vertical resizing mode: fixed or hug.???
* TextBaseline: [bool](#bool) = `False` - if text baseline alignment is enabled.
* StrokesIncluded: [bool](#bool) = `False` - if the Include Borders option is enabled.
* ReverseZIndex: [bool](#bool) = `False` - if the Last on Top option is enabled. ???
* Wrap: [bool](#bool) = `False` - if wrapping is enabled.
* WrapDistribute: [bool](#bool) = `False` - spacing between rows of wrapped content.
* WrapSpacing: [float](#float) = `0`

### <a name="BlurEffect"></a>BlurEffect
Defines the settings of the blur effect.

* Saturation: [float](#float) = `1` - saturation. Only for background blur.
* Radius: [float](#float) = `10` - blur Radius.
* Enabled: [bool](#bool) = `False` - if the blur is enabled.
* Type: [BlurType](#BlurType) = `Gaussian` - sets the blur type.

<details>
<summary>Sketch compatibility</summary>

* Center: [Point](#Point) = `[0,5,0,5]` - center point of motion blur.
* MotionAngle: [float](#float) = `0` - angle of motion for motion blur.
</details>

### <a name="BorderOptions"></a>BorderOptions
Defines the advanced options of borders, arrows, lines, and paths drawn with the Pen or Pencil tools.

* IsEnabled: [bool](#bool) = `False` - if an advanced option is enabled.
* LineCap: [LineCap](#LineCap) = `Butt` - defines the shape of line caps.
* LineJoin: [LineJoin](#LineJoin) = `Miter` - defines the appearance of line folds.
* Dash: [float[]](#float) - defines the size of dashes.

### <a name="ColorAsset"></a>ColorAsset
Colors stored in the document (color picker > dropdown list (global) > document).

* Id: [GUID](#GUID)
* Name: [string](#string)
* Color: [Color](#Color) = `00000000`

### <a name="ColorVariable"></a>ColorVariable
Color variables stored in the document.

* Id: [GUID](#GUID) - variable ID.
* Name: [string](#string) - variable name.
* Value: [Color](#Color) = `00000000` - color value of the variable.

### <a name="Columns"></a>Columns
Defines column settings in a layout grid.

* Enabled: [bool](#bool) = `False` - if columnns are enabled.
* Align: [LayoutHorizontalAlignment](#LayoutHorizontalAlignment) = `Left` - horizontal alignment settings.
* Offset: [int](#int) = `0` - offset value.
* Count: [int](#int) = `0` - number of columns.
* Gutter: [int](#int) = `0` - gutter value.
* Width: [int](#int) = `0` - column width.
* Color: [Color](#Color) = `00000000` - column color.

### <a name="Document"></a>Document
The document's .json structure.

* Id: [GUID](#GUID) - unique document ID.
* FromFigma: [bool](#bool) = `False` - if the document is imported from Figma.
* Images: [string[]](#string) - images stored in the document.
* Colors: [ColorAsset[]](#ColorAsset) - colors stored in the document (color picker > dropdown list (global) > document).
* Gradients: [GradientAsset[]](#GradientAsset) - gradients stored in the document (color picker > dropdown list (global) > document).
* Fonts: [Font[]](#Font) - shared fonts stored in the document.
* ColorVariables: [ColorVariable[]](#ColorVariable) - color variables stored in the document.
* LayerStyles: [SharedStyle[]](#SharedStyle) - layer styles stored in the document.
* TextStyles: [SharedStyle[]](#SharedStyle) - text styles stored in the document.
* Pages: [GUID[]](#GUID) - list of document pages.
* ColorSpace: [ColorSpace](#ColorSpace) = `Unmanaged`
* CurrentPageIndex: [int](#int) = `0`

### <a name="ExportFormat"></a>ExportFormat
Export settings.

* Size: [float](#float) = `0` - defines the width/height of the exported object. Valid only when ScaleType is *Width* or *Height*.
* Format: [string](#string) = `png` - export format. Default: PNG.
* Name: [string](#string) - user-defined suffix/preffix (string) added to the export file name. Default: empty.
* Naming: [NamingScheme](#NamingScheme) = `Suffix` - defines whether a suffix or preffix will be added to the export files name. Default: suffix.
* Scale: [float](#float) = `0` - defines the scale used when exporting an object. Valid only when ScaleType is set to *Scale*.
* Type: [ScaleType](#ScaleType) = `Scale` - defines the scale type: Scale(px)/Width/Height. The Width and Height types are currently not supported.

### <a name="ExportOptions"></a>ExportOptions
Export options.

* Formats: [ExportFormat[]](#ExportFormat) - list of export formats set by the user.
* Trim: [bool](#bool) = `False` - when enabled, trims empty pixels in exported images.

### <a name="Fill"></a>Fill
Defines the fill applied to a layer.

* Enabled: [bool](#bool) = `False` - if a fill is added.
* Color: [Color](#Color) = `00000000` - fill color.
* ColorId: [GUID?](#GUID) - color variable ID.
* Type: [FillType](#FillType) = `Color` - defines the fill type.
* Opacity: [float](#float) = `0` - defines the fill opacity.
* BlendMode: [BlendMode](#BlendMode) = `Normal` - defines the blend mode.
* Pattern: [Pattern](#Pattern) - defines the pattern for image fills: tile, stretch, etc.
* Gradient: [Gradient](#Gradient) - indicates that the fill is a gradient. ????

### <a name="Font"></a>Font
Embedded fonts stored in the document.

* Data: [string](#string) - name of the font file in the fonts folder.
* Name: [string](#string) - font name.
* FileName: [string](#string) - font file name.
* PostscriptNames: [string[]](#string) - postScript names of the font.

### <a name="Foreign"></a>Foreign
Defines entities from external libraries.

* ColorVariables: [ForeignColorVariable[]](#ForeignColorVariable) - color variables from an external library.
* LayerStyles: [ForeignSharedStyle[]](#ForeignSharedStyle) - layer styles from an external library.
* TextStyles: [ForeignSharedStyle[]](#ForeignSharedStyle) - text styles from an external library.
* Components: [ForeignComponent[]](#ForeignComponent) - components from an external library.

### <a name="ForeignColorVariable"></a>ForeignColorVariable
Describes color variables from external libraries.

* Id: [GUID](#GUID) - unique variable identifier.
* LibraryId: [GUID](#GUID) - unique library identifier.
* LibraryName: [string](#string) - library name.
* Color: [ColorVariable](#ColorVariable) - value of the color variable.

<details>
<summary>Sketch compatibility</summary>

* ComponentPrivate: [bool](#bool) = `False` - a Sketch flag for private shared color variables.
* RemoteId: [GUID](#GUID) - color variable ID in the external library.
</details>

### <a name="ForeignComponent"></a>ForeignComponent
Describes color components from external libraries.

* Id: [GUID](#GUID) - unique component identifier.
* LibraryId: [GUID](#GUID) - unique library identifier.
* LibraryName: [string](#string) - library name.
* Original: [Component](#Component) - original state of the component upon import.
* Component: [Component](#Component) - current state of the component.

<details>
<summary>Sketch compatibility</summary>

* ComponentPrivate: [bool](#bool) = `False` - a Sketch flag for private shared components.
</details>

### <a name="ForeignSharedStyle"></a>ForeignSharedStyle
Describes styles from external libraries.

* LibraryId: [GUID](#GUID) - unique library identifier.
* LibraryName: [string](#string) - library name.
* RemoteID: [GUID](#GUID) - style identifier in the external library.
* Id: [GUID](#GUID)

<details>
<summary>Sketch compatibility</summary>

* ComponentPrivate: [bool](#bool) = `False` - a Sketch flag for private shared styles.
</details>

### <a name="Gradient"></a>Gradient
An object that represents a gradient.

* Type: [GradientType](#GradientType) = `Linear` - type of the gradient.
* From: [Point](#Point) = `[0,5,0]` - position of the gradient start point.
* To: [Point](#Point) = `[0,5,1]` - position of the gradient end point.
* Side: [Point](#Point) = `[0,0]` - position of the gradient side point. Valid for radial and angular gragients.
* Stops: [GradientStop[]](#GradientStop) - list of other gradient points.

### <a name="GradientAsset"></a>GradientAsset
Gradients stored in the document (color picker > dropdown list (global) > document).

* Value: [Gradient](#Gradient) - values of gradients.
* Id: [GUID](#GUID)

### <a name="GradientStop"></a>GradientStop
A position-color pair representing a gradient stop.

* Pos: [float](#float) = `0` - value between 0 and 1 representing a position along gradient axis.
* Color: [Color](#Color) = `ffffffff` - color attached to a corresponding position.

### <a name="Grid"></a>Grid
Defines square grid settings for a frame.

* Enabled: [bool](#bool) = `False` - if the square grid is enabled.
* Color: [Color](#Color) = `00000000` - grid color.
* Size: [int](#int) = `10` - size of grid cells.

<details>
<summary>Sketch compatibility</summary>

* ThickTimes: [int](#int) = `10` - every N line should be thick.
</details>

### <a name="ImageFilters"></a>ImageFilters
Defines filters that can be applied to images.

* Enabled: [bool](#bool) = `False` - if a filter is applied to the image layer.
* Brightness: [float](#float) = `0` - brightness filter.
* Contrast: [float](#float) = `1` - contrast filter.
* Hue: [float](#float) = `0` - hue filter.
* Saturation: [float](#float) = `1` - saturation filter.

### <a name="InlineStyle"></a>InlineStyle
Style (bold, italic, etc.) applied to a part of text or single word within a text block.

* Start: [int](#int) = `0` - position where the style starts.
* Length: [int](#int) = `0` - length of the selection.
* Style: [TextStyle](#TextStyle) - style applied to the selection.

### <a name="Meta"></a>Meta
Contains metadata about the document.

* Version: [int](#int) = `0` - free Format version.
* App: [string](#string) - app name.
* Variant: [string](#string) - app variant: beta/standalone/store/web/etc.
* AppVersion: [string](#string) - app version.

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

* Id: [GUID](#GUID) - unique page ID.
* Name: [string](#string) - page name.
* Background: [Color](#Color) = `00000000` - canvas color.
* IsComponentPage: [bool](#bool) = `False` - if the page is used to store components.
* Rulers: [Rulers](#Rulers) - rulers applied by the user.
* Origin: [Point](#Point) = `[0,0]` - point where the user left off the page.
* Zoom: [float](#float) = `0` - zoom scale last applied to the page.
* Layers: [Layer[]](#Layer) - list of layers in the page.

### <a name="Pattern"></a>Pattern
Defines the image fill options.

* Type: [PatternFillType](#PatternFillType) = `Fill` - defines the fill type: tile, fill, stretch, fit, or crop.
* Image: [string](#string) - defines the image used as a fill.???? path/id or what???
* Rotation: [float](#float) = `0` - image rotation value, in degrees. Applicable to all types, except for crop.
* TileScale: [float](#float) = `1` - tile scale value. Applicable to the tile type only.
* Transform: [Matrix?](#Matrix) - defines how the image is cropped. Applicable to the crop type only.

### <a name="PrototypeViewport"></a>PrototypeViewport

* Name: [string](#string)
* Size: [Size](#Size) = `[0,0]`
* LibraryId: [GUID](#GUID)
* TemplateId: [GUID](#GUID)

### <a name="Rows"></a>Rows
Defines row settings in a layout grid.

* Enabled: [bool](#bool) = `False` - if rows are enabled.
* Align: [LayoutVerticalAlignment](#LayoutVerticalAlignment) = `Top` - vertical alignment settings.
* Offset: [int](#int) = `0` - offset value.
* Count: [int](#int) = `0` - number of rows.
* Gutter: [int](#int) = `0` - gutter value.
* Width: [int](#int) = `0` - row width.
* Color: [Color](#Color) = `00000000` - row color.

### <a name="Rulers"></a>Rulers
An object containing ruler origins and guideline positions.

* Guides: [int[]](#int) - positions of vertical guidelines on the Horizontal Ruler.
* VGuides: [int[]](#int) - positions of horizontal guidelines on the Vertical Ruler.

<details>
<summary>Sketch compatibility</summary>

* Origin: [Point](#Point) = `[0,0]` - ruler origin. Not supported in Lunacy. Sketch Compatibility
</details>

### <a name="ShadowEffect"></a>ShadowEffect
Defines the shadow options.

* Enabled: [bool](#bool) = `True` - if a shadow effect is enabled.
* Radius: [float](#float) = `0` - radius of the shadow blur.
* Color: [Color](#Color) = `00000000` - shadow color.
* ColorId: [GUID?](#GUID) - color variable ID.
* Spread: [float](#float) = `0` - shadow spread value.
* Offset: [Point](#Point) = `[0,0]` - how far the shadow is projected in the x and y directions.
* Opacity: [float](#float) = `0` - shadow opacity.
* BlendMode: [BlendMode](#BlendMode) = `Normal` - shadow blend mode.

### <a name="SharedStyle"></a>SharedStyle
Style saved in the document.

* Id: [GUID](#GUID) - unique style ID.
* Name: [string](#string) - style name.
* Style: [Style](#Style) - layer style settings.

### <a name="Style"></a>Style
Defines a set of properties that make up a style.

* MiterLimit: [int](#int) = `10` - ?????
* Opacity: [float](#float) = `1` - opacity of a layer.
* BlendMode: [BlendMode](#BlendMode) = `Normal` - blend mode: how a layer blends with the layers behind it.
* StartMarker: [Arrowhead](#Arrowhead) = `None` - defines the appearance of the starting point for arrows, lines, and open paths.
* EndMarker: [Arrowhead](#Arrowhead) = `None` - defines the appearance of the end point for arrows, lines, and open paths.
* Winding: [PathFillType](#PathFillType) = `EvenOdd` - fill options for overlapping paths: non-zero or even-odd.
* Fills: [Fill[]](#Fill) - list of fills applied to a layer.
* Borders: [Border[]](#Border) - list of borders applied to a layer.
* Shadows: [ShadowEffect[]](#ShadowEffect) - list of shadows applied to a layer.
* InnerShadows: [ShadowEffect[]](#ShadowEffect) - list of inner shadows applied to a layer.
* Blur: [BlurEffect](#BlurEffect) - definition of the blur effect applied to a layer.
* BorderOptions: [BorderOptions](#BorderOptions) - definition of border options.
* ImageFilters: [ImageFilters](#ImageFilters) - image filters applied to a layer.

### <a name="TextStyle"></a>TextStyle
Defines a set of properties that make up a text style.

* Color: [Color](#Color) = `ff000000` - text color.
* ColorId: [GUID?](#GUID) - color variable ID.
* Font: [string](#string) = `Inter` - text font.
* Size: [float](#float) = `12` - text size.
* ParagraphSpacing: [float](#float) = `0` - paragraph spacing.
* Kerning: [float](#float) = `0` - letter spacing.
* BaselineOffset: [float](#float) = `0` - text offset from the baseline.
* LineHeight: [float?](#float) - line spacing.
* Casing: [CharacterCasing](#CharacterCasing) = `Normal` - character case.
* Align: [TextHorizontalAlignment](#TextHorizontalAlignment) = `Left` - horizontal alignment applied to the text.
* Valign: [TextVerticalAlignment](#TextVerticalAlignment) = `Top` - vertical alignment applied to the text.
* List: [ListMarkerType](#ListMarkerType) = `None` - list type: numbered, bulleted, none.
* RTL: [bool](#bool) = `False` - if the text is RTL.
* Underline: [bool](#bool) = `False` - if the text is underlined.
* Strikethrough: [bool](#bool) = `False` - if the strikethrough option is applied to the text.
* BaselinePos: [BaselinePosition](#BaselinePosition) = `Normal` - text position against the baseline.

### <a name="IGridLayout"></a>IGridLayout
Defines layout grid settings for a frame.

* Enabled: [bool](#bool) = `False` - if layout grid is enabled.
* _t: [string](#string) = `COLS`

### <a name="ILayoutContainer"></a>ILayoutContainer
Defines an auto layout.

* _t: [string](#string) = `AUTO`

### <a name="Color"></a>Color Struct
32-bit ARGB unpremultiplied color value.

* Alpha: [byte](#byte) = `0` - gets the alpha component of the color.
* Red: [byte](#byte) = `0` - gets the red component of the color.
* Green: [byte](#byte) = `0` - gets the green component of the color.
* Blue: [byte](#byte) = `0` - gets the blue component of the color.

### <a name="Matrix"></a>Matrix Struct
A transformation matrix is standard way in computer graphics to represent translation and rotation.
            These are the top two rows of a 3x3 matrix. The bottom row of the matrix is assumed to be [0, 0, 1].
            This is known as an affine transform and is enough to represent translation, rotation, and skew.
            The identity transform is [1, 0, 0,   0, 1, 0].
            A translation matrix will typically look like: [1, 0, tx,   0, 1, ty]
            and a rotation matrix will typically look like: [cos(angle), -sin(angle), 0,   sin(angle), cos(angle), 0]
            If Matrix contains only translation it will be printed like point [0,5]

* ScaleX: [float](#float) - scale by x-coord. Usually should be 1.
            If it's -1 - layer is flipped horizontally.
            If it's some random number - it's a cos(angle).
* SkewX: [float](#float) - skew by x-coord. Usually should be 0.
            If it's some random number - it's a -sin(angle).
* TransX: [float](#float) - translation by x-coord.
* SkewY: [float](#float) - skew by y-coord. Usually should be 0.
            If it's some random number - it's a sin(angle).
* ScaleY: [float](#float) - scale by y-coord. Usually should be 1.
            If it's -1 - layer is flipped vertically.
            If it's some random number - it's a cos(angle).
* TransY: [float](#float) - translation by y-coord.

### <a name="Point"></a>Point Struct
A utility class to represent a point.

* X: [float](#float) - the x coordinate of the point.
* Y: [float](#float) - the y coordinate of the point.

### <a name="Rect"></a>Rect Struct
A utility class to represent a rectangle. Contains some methods to make interacting with a rectangle easier.

* Left: [float](#float) - a utility class to represent a rectangle. Contains some methods to make interacting with a rectangle easier.
* Top: [float](#float) - the x coordinate of the top-left corner of the rectangle. Or an object with
* Width: [float](#float) - the width of the rectangle.
* Height: [float](#float) - the height of the rectangle.

### <a name="Size"></a>Size Struct

### <a name="Thickness"></a>Thickness Struct

### <a name="Vertex"></a>Vertex Struct
!most critical moment in wiki doc. [x,y,flags,radius,fromX,fromY,toX,toY]

* Point: [Point](#Point) = `[0,0]` - base Point of a Vertex
* From: [Point](#Point) = `[0,0]` - first Control Point, Curve From
* To: [Point](#Point) = `[0,0]` - second Control Point, Curve To
* Radius: [float](#float) - corner Radius of a vertex point. It's stored in half because we don't need that much precision for corner radius
* Flags: [VertexFlags](#VertexFlags) = `None` - vertex flags, contains: CurveMode, hasFrom, hasTo and CornerStyle

### <a name="AnimationType"></a>AnimationType Enum

* `-1` None
* `0` FromRight
* `1` FromLeft
* `2` FromBottom
* `3` FromTop

### <a name="Arrowhead"></a>Arrowhead Enum
Defines the appearance of arrowheads.

* `0` None - no arrowheads.
* `1` Arrow - angle.
* `2` ArrowFilled - triangle.
* `3` Line - perpendicular Line.
* `4` Circle - cirlce arrowhead.
* `5` CircleFilled - filled circle arrowhead.
* `6` Square - square arrowhead.
* `7` SquareFilled - filled square arrowhead.

### <a name="BaselinePosition"></a>BaselinePosition Enum
Defines text position against the baseline.

* `0` Normal - text is aligned with the baseline.
* `1` Superscript - text is raised above the baseline.
* `-1` Subscript - text is lowered below the baseline.

### <a name="BlendMode"></a>BlendMode Enum
Defines the type of blend mode applied to a layer.

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
Defines the blur type.

* `0` Gaussian - gaussian blur.
* `1` Motion - motion blur. Currently not supported. // Sketch Compatibility
* `2` Zoom - zoom blur. Currently not supported. // Sketch Compatibility
* `3` Background - background blur.

### <a name="BoolOp"></a>BoolOp Enum
Types of bollean operations used to combine shapes.

* `-1` None - not set. Works like Difference or like Union depending on the context. ????
* `0` Union - creates a shape from the sum of the areas of the selected shapes.
* `1` Subtract - the opposite of Union. Removes the overlapping area(s) from the shape layer at the bottom of the selection.
* `2` Intersect - the resulting shape only includes the area where all selected shapes overlap.
* `3` Difference - the opposite of Intersect. Creates a shape from the areas where the selected shapes do not overlap.

### <a name="BorderPosition"></a>BorderPosition Enum
Defines the border postion.

* `0` Center - center.
* `1` Inside - inside.
* `2` Outside - outside.

### <a name="CharacterCasing"></a>CharacterCasing Enum
Defines letter case.

* `0` Normal - normal letter case.
* `1` UpperCase - upper case.
* `2` LowerCase - lower case.
* `3` TitleCase - title case.

### <a name="ComponentType"></a>ComponentType Enum
Types of components. Currently used for filtering only. Some of the types are not supported yet.

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
Defines the types of points on Bézier curves.

* `0` None - undefined.
* `1` Straight - straight.
* `2` Mirrored - mirrored.
* `3` Asymmetric - asymmetric.
* `4` Disconnected - disconnected.

### <a name="FillType"></a>FillType Enum
Defines the fill type.

* `0` Color - solid color fill.
* `1` Gradient - gradient fill.
* `4` Pattern - image fill.

### <a name="GradientType"></a>GradientType Enum
List of Gradient types.

* `0` Linear - linear gradient: two colors appear at opposite points of an object and blend, or transition into each other.
* `1` Radial - radial gradient: the transition between color stops is a circular pattern.
* `2` Angular - angular gradient: sweeps around the circumference.

### <a name="HorizontalAlignment"></a>HorizontalAlignment Enum
Defines how a set of layers is aligned horizontally.

* `0` Left - layers are aligned to the left.
* `1` Center - layers are horizontally centered.
* `2` Right - layers are aligned to the right.
* `3` Distribute - layers are horizontally justified.

### <a name="LayoutHorizontalAlignment"></a>LayoutHorizontalAlignment Enum
Defines horizontal alignment settings in layout grids.

* `0` Left
* `1` Center
* `2` Right
* `3` Stretch

### <a name="LayoutOrientation"></a>LayoutOrientation Enum
Orientation of an auto layout.

* `0` Horizontal - horizontal orientation.
* `1` Vertical - vertical orientation.

### <a name="LayoutVerticalAlignment"></a>LayoutVerticalAlignment Enum
Defines vertical alignment settings in layout grids.

* `0` Top
* `1` Middle
* `2` Bottom
* `3` Stretch

### <a name="LineCap"></a>LineCap Enum
Defines the shape of the end caps of open paths drawn with the Line, Arrow, or Pen/Pencil tools.

* `0` Butt - no cap (default).
* `1` Round - adds a rounded end to a path that extends past the vector point.
* `2` Square - similar to the rounded cap, but with straight edges.

### <a name="LineJoin"></a>LineJoin Enum
Defines the appearance of the corners for arrows and paths with corners drawn with the Pen/Pencil tool.

* `0` Miter - square.
* `1` Round - rounded.
* `2` Bevel - bevelled.

### <a name="ListMarkerType"></a>ListMarkerType Enum
Defines the type of a text list.

* `0` None - list without markers.
* `1` Bullet - bulleted list.
* `2` Numbered - numbered list.

### <a name="PathFillType"></a>PathFillType Enum
Defines the filling options for overlapping paths.

* `0` Winding - applies the non-zero rule.
* `1` EvenOdd - apllies the even-odd rule.

### <a name="PatternFillType"></a>PatternFillType Enum
Defines the image fill type.

* `0` Tile - tile. Duplicates the image in a tile pattern to fit the layer. The size of tiles is adjustable.
* `1` Fill - fill. Adjusts the image size to the layer’s width.
* `2` Stretch - stretch. Stretches the image to fit the layer’s width and height.
* `3` Fit - fit. Adjusts the image size to fit the layer’s height.
* `4` Crop - crop. Crops the image at user's discretion.

### <a name="ScaleType"></a>ScaleType Enum
Defines the scale type for exported objects.

* `0` Scale
* `1` Width
* `2` Height

### <a name="SizingMode"></a>SizingMode Enum
Defines the behavior of auto layout containers as their content is changed. ????

* `0` Auto - the container adjusts to the size of the content (hug).
* `1` Fixed - the container has a fixed size (fix).

### <a name="TextBehavior"></a>TextBehavior Enum
Defines textbox behavior options.

* `1` AutoHeight - the width of the textbox is fixed. Characters wrap to fit in the textbox. The height of the textbox automatically adjusts to fit its content.
* `2` Fixed - the size of the textbox is fixed and is independent of its content.
* `0` Flexible

### <a name="TextHorizontalAlignment"></a>TextHorizontalAlignment Enum
Defines how a text is aligned horizontally.

* `0` Left - text is aligned to the left.
* `1` Right - text is aligned to the right.
* `2` Center - text is horizontally centered.
* `3` Justify - text is horizontally justified.

### <a name="TextVerticalAlignment"></a>TextVerticalAlignment Enum
Defines how a text is aligned vertically.

* `0` Top - text is aligned to the top.
* `1` Middle - text is vertically centered.
* `2` Bottom - text is aligned to the bottom.

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
Defines how a set of layers is aligned vertically.

* `0` Top - layers are aligned to the top.
* `1` Center - layers are vertically centered.
* `2` Bottom - layers are aligend to the bottom.
* `3` Distribute - layers are vertically justified.

### <a name="DataInfo"></a>DataInfo
Information about auto generated texts. _//Lunacy Specific_

* Type: [DataType](#DataType) = `Unknown` - category of generated text (person, address, date, etc.).
* Field: [DataFieldType](#DataFieldType) = `Unknown` - type of generated text (full name or first name, city or ZIP code, etc.).
* Format: [string](#string) - string format for Data Type. Used for Date/Time values.

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
* ColorId: [GUID?](#GUID) - color variable ID.
* Property: [ColorOverrideType](#ColorOverrideType) = `Unknown` - color override type: none, fill, border, shadow, or inner shadow.
* Index: [int](#int) = `0` - ????
* Color: [Color](#Color) = `00000000`

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
Defines text color overrides. _//Sketch Compatibility_

* ColorId: [GUID?](#GUID) - color variable ID.
* Color: [Color](#Color) = `00000000`

### <a name="TextWeightOverride"></a>TextWeightOverride
Defines text weight overrides. _//Sketch Compatibility_

* Slant: [float](#float) = `0`
* Proportion: [float](#float) = `0`
* Symbolic: [float](#float) = `0`
* Weight: [float](#float) = `0`

### <a name="IGroupLayout"></a>IGroupLayout
 _//Sketch Compatibility_
### <a name="ColorOverrideType"></a>ColorOverrideType Enum
Defines types of color overrides. _//Sketch Compatibility_

* `0` Unknown
* `1` Fill
* `2` Border
* `3` Shadow
* `4` InnerShadow

### <a name="ColorSpace"></a>ColorSpace Enum
Document's color space (color scheme the document uses). _//Sketch Compatibility_

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
Controls the use of suffixes/prefixes in the names of export files. _//Sketch Compatibility_

* `0` Suffix - indicates that the file name comes with a user-defined suffix.
* `1` SecondaryPrefix - indicates that the file name comes with a user-defined prefix.
* `2` PrimaryPrefix - indicates that the file name comes with a user-defined prefix.

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