# SunamoParsing

## Short description

Knihovna pro parsování seznamů, základních typů a složitějších struktur z textu. Obsahuje Runner a testy.


Parsing list, basic types or more complex structures

## Overview

SunamoParsing is part of the Sunamo package ecosystem, providing modular, platform-independent utilities for .NET development.

## Main Components

### Key Classes

- **ListParser**
- **Parse**
- **Byte**
- **Double**
- **Integer**
- **Short**
- **ParseDefault**
- **ParserTwoValues**
- **StaticParse**
- **TryParse**

### Key Methods

- `ParseByte()`
- `ParseDouble()`
- `ParseInt()`
- `ParseIntMaxValue()`
- `ParseShort()`
- `ToString()`
- `ParseString()`
- `GetString()`
- `GetInt()`
- `GetFloat()`

## Installation

```bash
dotnet add package SunamoParsing
```

## Dependencies

- **Microsoft.Extensions.Logging.Abstractions** (v9.0.3)

## Package Information

- **Package Name**: SunamoParsing
- **Version**: 25.3.29.1
- **Target Framework**: net9.0
- **Category**: Platform-Independent NuGet Package
- **Source Files**: 13

## Related Packages

This package is part of the Sunamo package ecosystem. For more information about related packages, visit the main repository.

## License

See the repository root for license information.

<!-- sunamo:test-coverage:start -->
## Test coverage

| Metric | Value |
|---|---|
| Method | static |
| Test projects | 1 |
| Public types referenced by tests | 0/9 (0.0 %) |
| Public methods referenced by tests | 0/22 (0.0 %) |
| Line coverage | n/a |
| Branch coverage | n/a |
| Generated (UTC) | 2026-11-22 21:24 |

<!-- sunamo:test-coverage:data {"package":"SunamoParsing","container":"pinp","testProjects":1,"publicTypes":9,"typesReferencedByTests":0,"publicMethods":22,"methodsReferencedByTests":0,"lineRate":null,"branchRate":null,"method":"static","generatedUtc":"2026-11-22 21:24"} -->
<!-- sunamo:test-coverage:end -->
