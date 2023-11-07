# Free Format

FREE is an open source format for vector graphic files designed to be compact, human-readable, back-compatible, and optimized for multithreaded parsing.

A FREE file is a ZIP archive with the following structure:

- Pages — folder with JSON files containing layer structure and properties.
- Images — folder with raster assets. PNG, JPG, BMP, WEBP, GIF, TIFF, and ICO are supported.
- Fonts — folder with fonts embedded into the document, if any.
- document.json — file with document info data.
- foreign.json — file with objects from shared libraries.
- meta.json — file with app version, file format, last saved by, when, and other info.
- preview.png — a preview of the file.

Lunacy has the support for the Sketch format from the very beginning. Including both opening and saving such files. It's actually a great format with lots of advantages (JSON, everything bundled in a ZIP archive, extensions via UserInfo, a time-proved data structure, and many others) but over time, we've accumulated a long list of drawbacks that have been limiting Lunacy’s growth.

## What’s wrong with the Sketch format

### Stringent limitations

- No support for nested artboards (frames).
- You can’t  rotate artboards.
- You can’t apply styling options to artboards, round their corners, etc.
- Component overrides are only possible for a few fields supported by Sketch.
- There's no way to introduce new  layer types.

### Large file size

And there are reasons for this:

- Cumbersome MacOS-tied naming style for parameters: ``MSImmutableFreeformGroupLayout``, ``MSJSONFileReference``, ``MSAttributedStringColorAttribute``, ``NSCTFontSymbolicTrait``.
- Some of the parameter names are overly verbose: ``allowsDefaultTighteningForTruncation``, ``textStyleVerticalAlignmentKey``, ``automaticallyDrawOnUnderlyingPath``, ``includeBackgroundColorInInstance``, ``MSAttributedStringColorDictionaryAttribute``.
- The same applies to how the shape points are stored, resulting in enormous json files and slow file open times.

    ```json
    {
        "_class": "curvePoint",
        "cornerRadius": 0,
        "cornerStyle": 0,
        "curveFrom": "{0, 0}",
        "curveMode": 1,
        "curveTo": "{0, 0}",
        "hasCurveFrom": false,
        "hasCurveTo": false,
        "point": "{0, 0}"
        },
    ```
* Lots of fields have to be explicitly specified even for default values, i.e. they do not affect anything. But if you try to optimize a file, Sketch won’t open it. Take the fields from the above example and multiply it by millions of points in an average document.

    ```json
    "cornerRadius": 0,
    "cornerStyle": 0,
    "curveFrom": "{0, 0}",
    "curveMode": 1,
    "curveTo": "{0, 0}",
    "hasCurveFrom": false,
    "hasCurveTo": false,

    ```
* Also, object types are often explicitly defined, though they are self-evident from the context. Take ``"_class": "curvePoint"`` from the above example. And, again, multiply it by the number of points in the document.
* All Lunacy features that are not supported by Sketch we have to squeeze into userInfo, which is also far from being effective.

### Some objects have inefficient serialization, which slows down parsing performance.

* Points are described as strings, which adds extra complexity to parsing. First, you read a string like ``"{0, 0}"`` from JSON, and then you parse the values within that string. This impacts file reading performance.
* All IDs are specified as full GUIDs, like ``"1FCC7597-95CD-43E9-B264-18E8006C60B1"``, which is great in terms of data integrity but not the most efficient in terms of file size.
* Overrides have a peculiar format. For some reason, the data from this complex object is crammed into a single serialized string, containing an array of the target layer's IDs, the override type, and occasionally the override object's number:

    ``"42AB34F8-C748-46D5-9373-073296D64ABA/1FCC7597-95CD-43E9-B264-18E8006C60B1_color-1"``

    This approach is inefficient for parsing. Multiple JSON properties would work way better here.

## Downsides of the .fig format.

While working on import from Figma, we thoroughly explored the .fig format. It has one huge advantage — it’s binary and therefore extremely efficient in terms of disk space usage. But there are also serious downsides of the format: 

* Not human-readable.
* Proprietary with no public format specification.
* No backward compatibility. Every new version can introduce a completely new format if the Figma team deems it necessary. 

Due to this, supporting the .fig format is costly. It requires at least one experienced full-time developer with reverse engineering expertise dedicated solely to this task. And during Figma updates, sleepless nights may be required to quickly roll out an update to support the new format. Lots of products that previously supported the format have given up.

## Goals of the FREE format

We've made the decision to take the Sketch format and address all of its drawbacks while introducing new advantages. Therefore, the FREE format can be considered the successor to the Sketch format. We aimed for the format to be:

* Open source
* Fully back-compatible
* Human-readable
* Compact
* Easily extendable for third parties
* Optimized for high-performance multithreaded reading


We didn't rush the development and release of this format. We worked on it for an extended period, carefully refining all ideas and solutions, so that after new releases its back-compatibility would be as seamless as possible.

## Key differences from the Sketch format

* All fields have short, understandable names. For example, ``"hidden": true``.
* The object type field is given a concise name, ``"_t,"`` and is only specified where necessary, which is in just three places: layer type, grid layout type, and layout type.
* If a value is default, it is simply omitted from the file, even for complex objects.
* All GUIDs are written as ShortGUIDs, which are the base64 serialization of the byte data of the GUID. They retain all the GUID data but occupy 39% less space:

    - ``1FCC7597-95CD-43E9-B264-18E8006C60B1`` - 36 characters

    - ``_w7kV9AThEiBBxn5BtFCBA`` - 22 characters
* The Point data type is specified as an array of two numbers rather than a serialized string, which not only takes up slightly less space but also parses much faster:

    - Sketch format: ``"To": "{367, 566}"`` 

    - FREE format: ``"To": [367, 566]`` - 3 characters shorter
* The Size data type is also specified as an array:

    - Sketch format: ``"Width": 367, "Height": 566 ``

    - FREE format: ``"Size": [367, 566]`` - noticeably shorter
* The Matrix data type has two notation options: simple and with rotation.

    ``"Transform": [4, 6]`` - x and y coordinates of an object.

    ``"Transform": [0.9, 0.1, 4, 0.1, 0.9, 6]`` - ScaleX, SkewX, TransX, SkewY, ScaleY, TransY - this matrix includes the values of the following Sketch fields: x, y, rotation, isFlippedHorizontal, and isFlippedVertical. This is significantly more efficient.

* **The key difference**. The Vertex data type, which defines path points, and has several notation options. It's simply an array of numbers and can include up to eight values: ``[x, y, flags, radius, fromX, fromY, toX, toY]``. If the points on the right end of the array have default values, they are omitted. So, if toX, toY, fromX, fromY are all zeros, the array will look like ``[x,y,flags,radius]``. And if flags and radius are zeros, it becomes ``[x, y]``. Compare these two definitions of points of a rectangle, the most frequent element in all documents:

    - Skecth (682 characters)
    ```json 
    "points":[{"_class":"curvePoint","cornerRadius":0,"cornerStyle":0,"curveFrom":"{0, 0}","curveMode":1,"curveTo":"{0, 0}","hasCurveFrom":false,"hasCurveTo":false,"point":"{0, 0}"},{"_class":"curvePoint","cornerRadius":0,"cornerStyle":0,"curveFrom":"{1, 0}","curveMode":1,"curveTo":"{1, 0}","hasCurveFrom":false,"hasCurveTo":false,"point":"{1, 0}"},{"_class":"curvePoint","cornerRadius":0,"cornerStyle":0,"curveFrom":"{1, 1}","curveMode":1,"curveTo":"{1, 1}","hasCurveFrom":false,"hasCurveTo":false,"point":"{1, 1}"},{"_class":"curvePoint","cornerRadius":0,"cornerStyle":0,"curveFrom":"{0, 1}","curveMode":1,"curveTo":"{0, 1}","hasCurveFrom":false,"hasCurveTo":false,"point":"{0, 1}"}]
    ```
    - FREE (34 characters)
    ```json 
    "points":[[0,0],[1,0],[1,1],[0,1]]
    ```
    **20 times less in size!** Considering that Vertex is the most frequently encountered data type in the format, and a file may contain millions of them. Sacrificing some human-readability in this specific area, where it's not as crucial as in others, was a well-considered choice.
* For colors the FREE format uses HEX strings, while Sketch uses a complex object. Given that color is the second most frequently used object after Vertex, reducing its complexity is also highly critical:

    - Sketch: ``{"_class":"color","alpha":1,"blue":0.827451,"green":0.76862746,"red":0.27058825}`` - 80 characters.

    - FREE: ``“45C4D3”`` - 8 charecters, 10 times less.

    - Also, the color 333333 in the FREE format will go as 3, the color 4455FF — as 45F.
* Simplified, compact, and unbounded overrides. You can override any value. A single override can affect several values. In Sketch, the set of overrides is limited. Each field requires its own override. The number of fields is also limited and strictly defined. Plus parsing of complex strings can impact performance. The FREE format eliminates all these issues.

    ```json
    "overrides":[
    {
    "target":["bmlSSK7GO0SzhLA-YSdg3Q","TE1yOSobJkONa7C7EvKfig"],
    "locked":true,
    "hidden":false,
    "fills":[{"color":"B2EBF2"}],
    "link":"back"
    }] 
    ```
* ``document.json`` does not include any foreign properties. They are stored in a separate file, named ``foreign.json``. This prevents ``document.json`` from growing to enormous sizes, up to several gigabytes in some cases. Instead, it remains small and quick to parse. Foreign objects are parsed in a separate thread, ensuring it doesn't impact the file's opening speed.
* [Currently not implemented, coming soon] If a page size exceeds 20MB, it will be divided into 20MB parts, with the division occurring at the top-level artboards. For example, if a page features top-level artboards of 30MB, 10MB, 5MB, 1MB, and 10MB in size, it will be split into parts of 30MB, 16MB, and 10MB. We've observed that in very large files, there's typically one page that is 5-50 times larger than the others. Consequently, parsing it takes N times longer, monopolizes one execution thread, and significantly slows down the file opening. This approach will allow parallel parsing of large pages across multiple CPU threads, and greatly improve the opening speed of such files.

## Results

On small files or files with few layers but many images, improvements might not be very noticeable. But you will definitely see them on massive files with dozens or even hundreds of thousands of layers.

* JSON file sizes are reduced by a factor of 5-10. It's worth noting that JSON compresses well, and after compression, the difference consistently leads to a substantial reduction by a factor of 2. In our case, when transmitting JSON data over the internet, especially in cloud documents, this 5-10 times reduction significantly saves bandwidth for users and our servers.

* The size of images remains unchanged because they are already maximally compressed. However, it's important to mention that the FREE format supports various image formats, including JPG, PNG, WEBP, GIF, and others, without the need to convert them to PNG, as some competitors do. Converting JPG to PNG often significantly increases image size. Lunacy doesn't do this.

* The file opening process has improved by an average of 30%, and in some cases, especially with very large files, the speedup can be as high as 200%.

## Side-by-side comparison

Assume that we have a red rectangle on the canvas. In Sketch, it would result in a JSON representation of **1639 characters** (measured with the JSON formatted into a single line).

```json
{
  "_class": "rectangle",
  "do_objectID": "5FF2A422-C956-4F7A-9E49-C295DB00A4D9",
  "booleanOperation": -1,
  "isFixedToViewport": false,
  "isLocked": false,
  "isVisible": true,
  "isTemplate": false,
  "layerListExpandedType": 0,
  "name": "Rectangle",
  "nameIsFixed": false,
  "resizingConstraint": 63,
  "resizingType": 0,
  "rotation": 0,
  "shouldBreakMaskChain": false,
  "exportOptions": {
    "_class": "exportOptions",
    "includedLayerIds": [],
    "layerOptions": 0,
    "shouldTrim": false,
    "exportFormats": []
  },
  "frame": {
    "_class": "rect",
    "constrainProportions": false,
    "height": 428,
    "width": 431,
    "x": 1887,
    "y": -751
  },
  "clippingMaskMode": 0,
  "hasClippingMask": false,
  "style": {
    "_class": "style",
    "endMarkerType": 0,
    "miterLimit": 10,
    "startMarkerType": 0,
    "windingRule": 1,
    "fills": [
      {
        "_class": "fill",
        "isEnabled": true,
        "fillType": 0,
        "color": {
          "_class": "color",
          "alpha": 1,
          "blue": 0,
          "green": 0,
          "red": 1
        }
      }
    ]
  },
  "edited": false,
  "isClosed": true,
  "pointRadiusBehaviour": 1,
  "points": [
    {
      "_class": "curvePoint",
      "cornerRadius": 0,
      "cornerStyle": 0,
      "curveFrom": "{0, 0}",
      "curveMode": 1,
      "curveTo": "{0, 0}",
      "hasCurveFrom": false,
      "hasCurveTo": false,
      "point": "{0, 0}"
    },
    {
      "_class": "curvePoint",
      "cornerRadius": 0,
      "cornerStyle": 0,
      "curveFrom": "{1, 0}",
      "curveMode": 1,
      "curveTo": "{1, 0}",
      "hasCurveFrom": false,
      "hasCurveTo": false,
      "point": "{1, 0}"
    },
    {
      "_class": "curvePoint",
      "cornerRadius": 0,
      "cornerStyle": 0,
      "curveFrom": "{1, 1}",
      "curveMode": 1,
      "curveTo": "{1, 1}",
      "hasCurveFrom": false,
      "hasCurveTo": false,
      "point": "{1, 1}"
    },
    {
      "_class": "curvePoint",
      "cornerRadius": 0,
      "cornerStyle": 0,
      "curveFrom": "{0, 1}",
      "curveMode": 1,
      "curveTo": "{0, 1}",
      "hasCurveFrom": false,
      "hasCurveTo": false,
      "point": "{0, 1}"
    }
  ],
  "fixedRadius": 0,
  "needsConvertionToNewRoundCorners": false,
  "hasConvertedToNewRoundCorners": true
}
```

In Lunacy's FREE format the same will take only **110 characters**. A 15-fold difference.

```json
{
  "_t": "RECT",
  "id": "IqTyX1bJek-eScKV2wCk2Q",
  "transform": [1887,-751],
  "size": [431,428],
  "fills": [{"color":"F00"}]
}
```
## Plans

After fully adapting the new format and polishing it, we plan to develop, test, and, once acceptable results are achieved, introduce support for a binary variation of the format. This means that within the ZIP archive, you'll have .BIN files instead of .JSON. The idea is to maintain the same structure and practices but represent the data in the most efficient manner. Additionally, in the case of providing such serialization options, we will offer a converter that will be able to convert the data to JSON and back, preserving user-readability and maximum file size efficiency. If successful, we can attain the efficiency of the .fig format without its drawbacks.

## Base Types

Free format is NULL-free, NaN-free and Infinity-free - if any of this values are in JSON - it's broken. 

* <a name="float"></a>float - 32bit single-precision floating-point number
* <a name="int"></a>int - 32bit signed integer
* <a name="byte"></a>byte - 8-bit unsigned integer
* <a name="bool"></a>bool - Boolean (true or false) value
* <a name="string"></a>string - text as a sequence of UTF-8 code units
* <a name="GUID"></a>GUID - globally unique identifier, with base64 encryption

## Layers

