# Free Format Specification

Free format is NULL-free, NaN-free and Infinity-free - if any of these values are in JSON - it's broken.

* **GUID** — globally unique identifier, with base64 encoding, length is always 22 chars. Examples: `R1o2w3_4D5i6n7g8_000AA`, `N1a2m3-4C5o6n7t8_910AA`, `reY4TrsLHUeFk-E0CtyS5A`
* **Color** — ARGB hex string without `#`, supports minified values. Examples: `F` = `FFFFFF`, `34` = `343434`, `F33` = `FF3333`, `FFAA41`, `9900FF47`.
* **Point** — array of 2 floats [x,y]. Example: `[3,7]`.
* **Size** — array of 2 floats [width,height]. Example: `[3,7]`.
* **Rect** — array of 4 floats [left,top,width,height]. Example: `[0,0,100,100]`.
* **Thickness** — array of 4 floats [left,top,right,bottom]. Example: `[8,4,8,4]`.
* **Matrix** — affine 2x3 matrix. Array of 2 or 6 floats. If 2 floats - it's just a position(translation) [x, y]. Example: `[100,500]`. If 6 floats - it's a transformation matrix [scaleX,skewX,transX,skewY,scaleY,transY]. Identity matrix is `[1,0,0,0,1,0]`. A rotation matrix will typically look like: [cos(angle), -sin(angle), 0, sin(angle), cos(angle), 0]. Example for 90° is `[0,-1,0,1,0,0]`.
* **Vertex** — Path vertex point. Array of 2, 3, 4, 6 or 8 floats. If array length is 2 - it's just a point [x, y]. Example: `[4,2]`. Third value, if present, is a byte enum of `CurveMode`. Fourth value, if present, is a corner radius. The next possible 2 values is: fromX, fromY - first control point position. And the last 2 floats is: toX, toY - second control point position. Full spec is: `[x, y, mode, radius, fromX, fromY, toX, toY]`.
* Layers requiring `_t` field to specify type (e.g., `"RECT"`, `"TEXT"`, `"GROUP"`)
* All non-enum fields below are in format: `(type) (name) = (default value)`. If property value is default - it can be skipped.

## Icon — external data object. Set a searchable english name and icon will be downloaded from Icons8 server. Use this to save tokens. Examples: `Home`, `Back`, `Close`.

Has all properties of `Layer`, plus:
* string _t = "ICON"

## Photo — external data object. Set a searchable english name and photo will be downloaded from Icons8 server. Use this to save tokens.

Has all properties of `Layer`, plus:
* string _t = "PHOTO"

## Avatar — external data object. Random human avatar will be downloaded from Icons8 server. Use this to save tokens.

Has all properties of `Layer`, plus:
* string _t = "AVATAR"

