# TypeSharp.Attributes

[![NuGet version](https://img.shields.io/nuget/v/TypeSharp.Attributes.svg?label=Version)](https://www.nuget.org/packages/TypeSharp.Attributes)
[![NuGet downloads](https://img.shields.io/nuget/dt/TypeSharp.Attributes.svg?label=Downloads)](https://www.nuget.org/packages/TypeSharp.Attributes)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![GitHub stars](https://img.shields.io/github/stars/siyavuyachagi/typesharp?label=Stars)](https://github.com/siyavuyachagi/typesharp/stargazers)
[![Sponsor](https://img.shields.io/badge/Sponsor-💖-ff69b4)](https://github.com/sponsors/siyavuyachagi)

C# attributes for controlling [TypeSharp](https://github.com/siyavuyachagi/typesharp) TypeScript generation.

> **TypeSharp** is a direct C# → TypeScript type generator. This package provides the attributes that let you fine-tune what gets generated and how — without touching the CLI config.

---

## Installation

```bash
dotnet add package TypeSharp.Attributes
```

---

## Attributes

| Attribute           | Target       | Description                                               |
| ------------------- | ------------ | --------------------------------------------------------- |
| `[TypeSharp]`       | (Class/Enum) | Main TypeSharp attribute, TypeSharp target this attribute |
| `[TypeIgnore]`      | Property     | Excludes the property from TypeScript output              |
| `[TypeName("...")]` | Property     | Overrides the property name in the generated TypeScript   |
| `[TypeAs("...")]`   | Property     | Overrides the inferred TypeScript type                    |

---

## Usage

### `[TypeIgnore]`

Exclude a property entirely from the generated output.

```csharp
using TypeSharp.Attributes;

[TypeSharp]
public class UserDto
{
    public string Email { get; set; }

    [TypeIgnore]
    public string PasswordHash { get; set; }
}
```

Generated TypeScript:

```typescript
export interface UserDto {
  email: string;
}
```

---

### `[TypeName("...")]`

Override the property name in the generated TypeScript output.

```csharp
[TypeSharp]
public class UserDto
{
    [TypeName("created_at")]
    public DateTime CreatedAt { get; set; }

    [TypeName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
```

Generated TypeScript:

```typescript
export interface UserDto {
  created_at: string;
  updated_at: string;
}
```

---

### `[TypeAs("...")]`

Override the inferred TypeScript type for a property.

```csharp
[TypeSharp]
public class UserDto
{
    [TypeAs("Date")]
    public DateTime CreatedAt { get; set; }

    [TypeAs("'admin' | 'user' | 'guest'")]
    public string Role { get; set; }
}
```

Generated TypeScript:

```typescript
export interface UserDto {
  createdAt: Date;
  role: "admin" | "user" | "guest";
}
```

---

### Combining attributes

All three attributes can be stacked together or alongside `[Obsolete]`.

```csharp
[TypeSharp]
public class ProductDto
{
    public Guid Id { get; set; }

    [TypeName("display_name")]
    public string Name { get; set; }

    [TypeAs("'active' | 'inactive'")]
    public string Status { get; set; }

    [TypeIgnore]
    public string InternalCode { get; set; }

    [Obsolete("Use Status instead.")]
    public bool IsActive { get; set; }
}
```

Generated TypeScript:

```typescript
export interface ProductDto {
  id: string;
  display_name: string;
  status: "active" | "inactive";
  /** @deprecated Use Status instead. */
  isActive: boolean;
}
```

---

## Requirements

- .NET Standard 2.0 or later
- [TypeSharp CLI](https://www.npmjs.com/package/@siyavuyachagi/typesharp) `>= 0.1.1`

---

## Related

- [TypeSharp CLI (npm)](https://www.npmjs.com/package/@siyavuyachagi/typesharp) — the generator that reads these attributes
- [TypeSharp GitHub](https://github.com/siyavuyachagi/typesharp) — source, docs, and issue tracker

---

## License

MIT © [Siyavuya Chagi](https://github.com/siyavuyachagi)

---

Built with ❤️ in South Africa 🇿🇦
