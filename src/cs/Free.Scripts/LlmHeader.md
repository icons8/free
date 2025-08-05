# Free Format Specification

## Base Types

Free format is NULL-free, NaN-free and Infinity-free - if any of this values are in JSON - it's broken. 

* float - 32bit single-precision floating-point number
* int - 32bit signed integer
* byte - 8-bit unsigned integer
* bool - Boolean (true or false) value
* string - text as a sequence of UTF-8 code units
* GUID - globally unique identifier, with base64 encryption, length is always 22 chars. 

## Layers

