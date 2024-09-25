## Changelog

### Version 4 - TBD

* `Link` property is replaced by `Flows` list of prototyping interactions.

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

by Icons8 LLC 2023