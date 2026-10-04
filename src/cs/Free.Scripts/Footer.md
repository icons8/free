## Changelog

### Version 11 - 27.09.2026
* Accept empty font variation objects in text layers, text styles, and inline styles.
* Skip malformed argument values in bindings when loading a document, so one damaged binding does not prevent the rest of the document from opening.
* Added glass blur type `4` and its light angle, light intensity, refraction, depth, dispersion, frost, and splay settings.
* Added float variable bindings and numeric fallbacks for all seven glass settings.
* Glass depth and frost are document-space lengths; intensity, refraction, dispersion, and splay are percentages.
* Preserve disabled blur and glass settings on layers and effect styles.
* Corrected the documented blur `enabled` default to `true` when a blur object is present.

### Version 10 - 07.09.2026
* Added variable font coordinates and optical sizing to text layers, text styles, and inline styles.
* Added variable bindings for individual font variation axes, including numeric fallback values.
* Added `collectionIndex` for fonts embedded from TrueType and OpenType collections.
* Documented page measurements and synchronized field names, defaults, and enum values with the Lunacy reader and writer.

### Version 9 20.05.2026
* Added `Binds` to `InlineStyle`.
* Added variables to `Grid`, `Columns` and `Rows`.
* Added variables to `BlurEffect` and `ShadowEffect`.

### Version 8 15.03.2026
* Added `SlotComponentProperty`.
* Added `Slot` layer and `Slots` property to `Document` and `SharedLibrary`.
* Added `StateBind` list to `Component`.
* Added `Expression`, `ExpressionFunction`, `Argument`. 
* Added `Bind` list to `Layer` and `InstanseSetting` list to `Instance`.
* New flow actions: `ConditionalAction`, `SetVariableAction`, `SetThemeAction`.
* Added Zoom and Motion blur.
* Added Diamond Gradient.

### Version 7 20.02.2026
* `FixedHorizontal` and `FixedVertical` are replaced by `FixWidth` and `FixHeight`.
* `StretchHorizontal` and `StretchVertical` are replaced by `StretchWidth` and `StretchHeight`.

### Version 6 - 18.02.2026

* Added `Pos` and `Frame` fields to simplify `Transform` field in usual cases.
* Added `Fill` and `Border` fields to simplify usual case of single color fills and borders.

### Version 5 - 11.07.2025

* New layer types: `Section` and `States`.
* `Hotspot` layer type is removed.
* We are dropping compatibility for sketch smart layout fields, sketch overlay fields, and sketch instance spacing fields.
* New `Custom` field for `Layer`. It is for plugin data and for anything that's not specified in a FREE format.
* `FigmaId` field added to the `Component`.
* `Component` now can be inside any group/frame/section.
* `CornerRadius` and `SmoothCorners` fields are now in `Style` and `Styled` layers.
* Also we are dropping support for `Frame` fields: `HasBackgound`, `Background`, `BackgroundInExport`, `BackgroundInInstance`.
* `Flow` now contains not one, but a list of actions.
* `Border` and `Fill` now sharing the same `Fill` object. `Thickness` and `LinePos` now in the `Layer`. `BorderOptions` are inside `Layer` too.
* `SharedStyle` and `Style` objects is removed. `FillStyle`, `TextStyle`, `EffectStyle`, `GridLayoutStyle` objects are added instead.
* `StyleId` is removed from `Layer`. `FillsId`, `BordersId`, `EffectsId` properties are added to a `Layer`, `GridsId` to `Frame` and `TextStyleId` to `Text` instead.
* New variable types: `BoolVariable`, `StringVariable`, `FloatVariable`. `ColorVariables` properties of a `Document` and `Library` are renamed to `Variables` and now contain a list of `VariableCollection`.
* `Component` and `States` now have `Properties`. `Instance` also has `Assigns` to component properties.
* `TextProperties` `Color` and `ColorId` is replaces with array of `Fill`.
* `InlineStyle` now has `FillsId` and `TextStyleId` fields.
* `LINE` layer type is added. Previously it was saved as `PATH`.
* Added `Connectors`.
* `Container` renamed to `AutoLayout`.
* `Sizing` and `VSizing` are replaced by `FixedHorizontal` and `FixedVertical`.
* `Orientation` replaced by `Vertical` boolean.
* `LayoutStretch` renamed to `StretchHorizontally`.
* `LayoutGrowStretch` renamed to `StretchVertically`.
* `LayoutFixPos` renamed to `FixPos`.
* Added `FlowScrollOverflow`.
* Added `Spring` animation parameters.
* `TextProperties` removed. Now this properties are inside `Text` layer and `InlineStyle`.
* `Size` renamed to `FontSize` where font size is set.
* `Fixed` replaced by `ScrollBehavior`.

### Version 4 - 20.01.2025

* `Link` property is replaced by `Flows` list of prototyping triggers and actions.

### Version 3 - 25.09.2024

* Preview now in `.webp` format, not `.png`. File name is `preview.webp`.
* WEBP is now a preferred format for images. New images created in Lunacy will use `.webp`.

### Version 2 - 11.08.2024

* `Shared.json` is removed. Now all shared libraries data have a new efficient structure and can be found inside `shared` folder. 
Separate file is created for every library source - this will significantly increase document open speed in multithreaded way if document use a lot of components from different shared libraries.
* Now `SharedStyle`s are not grouped by text/layer category. All in one container. To check if style is text style - check if it has text `TextStyle` property.
* `Export` optimized to be a simple list of `ExportOption`. Some sketch-related fields removed.

### Version 1 - 19.03.2024

* Initial Version

## Made by Icons8

`.free` is the native format of **[Lunacy](https://icons8.com/lunacy?utm_source=github)**, our free design app with the whole Icons8 library built in — **[1.5M+ icons](https://icons8.com/icons?utm_source=github)** ([Color](https://icons8.com/icons/color?utm_source=github), [3D Fluency](https://icons8.com/icons/3d-fluency?utm_source=github), [Liquid Glass](https://icons8.com/icons/liquid-glass?utm_source=github)) and **[110,000+ illustrations](https://icons8.com/illustrations?utm_source=github)** ([Cherry](https://icons8.com/illustrations/styles/cherry?utm_source=github), [Bouncy](https://icons8.com/illustrations/styles/bouncy?utm_source=github), [3D Stickle](https://icons8.com/illustrations/styles/3d-stickle?utm_source=github)), free to use.

by Icons8 LLC
