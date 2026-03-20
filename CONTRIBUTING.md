# Contributing to TypeSharp.Attributes

Thank you for your interest in contributing! This document walks you through everything you need to get started.

---

## Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Project Overview](#project-overview)
- [Getting Started](#getting-started)
- [Development Workflow](#development-workflow)
- [Making Changes](#making-changes)
- [Submitting a Pull Request](#submitting-a-pull-request)
- [Release Process](#release-process)
- [Getting Help](#getting-help)

---

## Code of Conduct

This project follows a Code of Conduct that all participants are expected to uphold. Please read [CODE-OF-CONDUCT.md](./CODE-OF-CONDUCT.md) before contributing.

---

## Project Overview

TypeSharp.Attributes is a lightweight C# attribute package that works alongside the [TypeSharp CLI](https://www.npmjs.com/package/@siyavuyachagi/typesharp) to control TypeScript generation from C# models.

| Attribute           | Purpose                                   |
| ------------------- | ----------------------------------------- |
| `[TypeIgnore]`      | Exclude a property from TypeScript output |
| `[TypeName("...")]` | Override the generated property name      |
| `[TypeAs("...")]`   | Override the inferred TypeScript type     |

> This package has zero runtime dependencies — it is purely attribute definitions targeting `netstandard2.0`.

---

## Getting Started

### Prerequisites

- .NET SDK `>= 6.0`
- Git

### Fork & Clone

```bash
# Fork the repo on GitHub, then clone your fork
git clone https://github.com/<your-username>/typesharp.git
cd typesharp/TypeSharp.Attributes

# Add the upstream remote
git remote add upstream https://github.com/siyavuyachagi/typesharp.git
```

### Build

```bash
dotnet build
```

### Pack locally

```bash
dotnet pack --configuration Release
```

---

## Development Workflow

Always create a new branch for your work. Never commit directly to `main`.

```bash
# Pull latest changes from upstream
git fetch upstream
git checkout main
git merge upstream/main

# Create a feature or fix branch
git checkout -b feat/your-feature-name
# or
git checkout -b fix/your-bug-description
```

### Branch Naming

| Type    | Pattern              | Example                           |
| ------- | -------------------- | --------------------------------- |
| Feature | `feat:<description>` | `feat:type-readonly-attribute`    |
| Bug fix | `fix:<description>`  | `fix:typeignore-on-init-property` |
| Docs    | `docs:<description>` | `docs:update-readme`              |

---

## Making Changes

### Adding a new attribute

1. Create a new file in `TypeSharp.Attributes/Attributes/`
2. Follow the existing pattern — sealed class, single `AttributeUsage` target, primary constructor
3. Use `namespace TypeSharp.Attributes`
4. Add XML doc comments
5. Update `README.md` with the new attribute — include a C# example and the generated TypeScript output
6. Update the attributes table in `README.md`

**Example structure:**

```csharp
namespace TypeSharp.Attributes;

/// <summary>
/// Your attribute description here.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class TypeYourAttribute(string value) : Attribute
{
    public string Value { get; } = value;
}
```

### Updating an existing attribute

- Do not change constructor parameter names — this is a breaking change for existing users
- Do not change `AttributeUsage` targets without a major version bump
- Document any behaviour changes clearly in your PR description

---

## Submitting a Pull Request

### Before Opening a PR

```bash
# Make sure the build passes
dotnet build

# Pack to verify the output is clean
dotnet pack --configuration Release
```

### PR Checklist

- [ ] Branch is based on the latest `main`
- [ ] `dotnet build` passes with no errors or warnings
- [ ] New attribute follows the existing pattern
- [ ] `README.md` updated with new attribute docs
- [ ] PR title follows the format: `type: short description`
- [ ] PR description explains what changed and why

### PR Title Format

```
feat: add TypeReadOnly attribute
fix: TypeIgnore not working on init-only properties
docs: add TypeAs union type example to README
chore: bump target framework
```

---

## Release Process

Releases are handled by the maintainer via GitHub Actions. Publishing to NuGet is triggered automatically when a GitHub Release is published with a version tag.

| Tag             | NuGet Version  |
| --------------- | -------------- |
| `v1.0.0`        | `1.0.0`        |
| `v1.1.0`        | `1.1.0`        |
| `v1.0.0-beta.1` | `1.0.0-beta.1` |

Contributors do not need to manage versioning — just open a PR and the maintainer handles the rest.

---

## Getting Help

- Browse open [GitHub Issues](https://github.com/siyavuyachagi/typesharp/issues)
- Open a new issue to ask a question, report a bug, or propose a new attribute
- Read the [README.md](./README.md) for full usage examples

---

Built with ❤️ in South Africa 🇿🇦 — thank you for contributing to TypeSharp.Attributes!
