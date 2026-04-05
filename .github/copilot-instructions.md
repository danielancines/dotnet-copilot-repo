# Copilot Instructions for Codebase

## General Principles

* Always use regions for (Only add regions with has content, NEVER add an empty region)
  * Events
    * Definition: It contains events for a class
    * Region name: Events
  * Fields
    * Definition: It contains fields using the notation _<field_name>, for convention fields are private
    * Region name: Fields
  * Constructors
    * Definition: It contains constructors for a class
    * Region name: Constructor
  * Properties
    * Definition: It contains properties for a class
    * Region name: Properties         
  * Public Methods
    * Definition: It contains public and override methods for a class
    * Region name: Public Methods 
  * Private Methods
    * Definition: It contains private methods for a class
    * Region name: Private Methods        
* The order for regions MUST be:
  * Events, Fields, Constructor, Properties, Public Methods, Private Methods

## Language Features

* Use pattern matching and switch expressions where it improves clarity
* Use `nameof` instead of string literals for member references
* Use `is null` / `is not null` instead of `== null` / `!= null`
* Prefer expression-bodied members only for simple logic

## Null Safety

* Trust nullable reference types
* Do not use the null-forgiving operator (`!`) to silence warnings

## Class Design

* Prefer `sealed` for classes not intended for inheritance
* Design for composition over inheritance
* NEVER use more than one class, enum, interface in the same .cs file
* Events MUST use WeakEventManager, don't use EventHandler to avoid Memory Leak

## Code Quality

* Keep methods small and focused
* Prefer explicit and meaningful naming for methods, properties, fields
* Binding MUST have mode on it
  * Prefer Mode=OneTime for Commands

## Architecture

* Respect separation of concerns
* Ensure code is testable

