---
description: "Instructions and code guidelines for classes on entire project"
applyTo: "**/*.cs"
---

# Code Guidelines

* Keep methods small and focused
* Prefer explicit and meaningful naming for methods, properties, fields
* Code need to be inside regions
* Only one class per .cs file
* Use pattern matching and switch expressions where it improves clarity
* Use `nameof` instead of string literals for member references
* Use `is null` / `is not null` instead of `== null` / `!= null`
* Prefer expression-bodied members only for simple logic