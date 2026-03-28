# SunamoParsing

A .NET library for parsing lists, basic types, and more complex structures from string data.

## Features

- **StaticParse** - Static methods for parsing typed values (int, float, double, DateTime, Guid, etc.) from a list of strings by index
- **ListParser** - Base class for index-based parsing from an internal string list
- **Parse** - Simple type parsing (byte, double, integer, short) with default fallback values on failure
- **ParseDefault** - Type parsing with custom default values when parsing fails
- **ParserTwoValues** - Parsing and formatting of delimiter-separated two-value strings

## Target Frameworks

**TargetFrameworks:** `net10.0;net9.0;net8.0`

## Installation

```
dotnet add package SunamoParsing
```

## Links

- [NuGet](https://www.nuget.org/profiles/sunamo)
- [GitHub](https://github.com/sunamo/PlatformIndependentNuGetPackages)
- [Developer site](https://sunamo.cz)

For feature requests or bug reports: [Email](mailto:radek.jancik@sunamo.cz) or on GitHub
