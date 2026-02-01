## Changelog

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

by Icons8 LLC