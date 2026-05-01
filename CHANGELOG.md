# Changelog

All notable changes to TypeSharp.Attributes will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](https://semver.org/).

---

## v1.0.4 - 2026-05-01

### Added
- **Union** — New attribute for adding union types in TypeScript generation.
- **AllowMultiple** rule to be _false_ for all attributes, disallowing multiple attributes on the same member.

### Deprecated
- **`TypeSharp.Attributes.TypeSharpAttribute`** — The attribute has moved to the `TypeSharp` namespace. `TypeSharp.Attributes.TypeSharpAttribute` is now marked `[Obsolete]` and will be removed in a future version.

---

## v1.0.3 - 2026-04-27

### Added
- **Added package icon** — The package now includes a logo for better visual identification.

---

## v1.0.2 - 2026-03-21

### Changed
- **`[TypeSharp]` now accepts an optional type name argument** — `[TypeSharp("my_name")]` overrides the generated TypeScript type name, taking precedence over any naming convention. `[TypeSharp]` without an argument is unchanged.

---

## v1.0.1 - 2026-02-19

### Added
- Initial release of `TypeSharp.Attributes`
- `[TypeSharp]` — marks a class or enum for TypeScript generation
- `[TypeIgnore]` — excludes a property from generated output
- `[TypeName("...")]` — overrides the property name in generated TypeScript
- `[TypeAs("...")]` — overrides the inferred TypeScript type for a property