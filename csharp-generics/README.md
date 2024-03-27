# C# Generics and Access Modifiers

## Generics

Generics in C# allow you to define classes, interfaces, and methods with placeholder types, enabling reusability and type safety.

### Purpose of Generics

- **Reusability**: Generics enable you to write code that can work with any data type.
- **Type Safety**: They provide compile-time type checking, reducing the risk of runtime errors.

### Common Generic Classes and Interfaces in .NET

- `List<T>`
- `Dictionary<TKey, TValue>`
- `Queue<T>`
- `Stack<T>`
- `IEnumerable<T>`

### Creating Generic Classes

You can create generic classes by specifying type parameters in angle brackets after the class name.

### Creating Generic Methods

Similarly, you can create generic methods within non-generic classes by defining type parameters before the return type.

## Access Modifiers

Access modifiers control the accessibility of classes and their members.

- **Public**: Accessible from any other class.
- **Private**: Accessible only within the containing class.
- **Protected**: Accessible within the containing class and its subclasses.
- **Internal**: Accessible within the same assembly.
- **Protected Internal**: Accessible within the same assembly or by derived classes.

## Default(T) Expression

The `default(T)` expression returns the default value of a type `T`.

## Covariance and Contravariance

Covariance allows a method to return a more derived type than that specified by the generic parameter, while contravariance allows a method to accept parameters of less derived types than specified by the generic parameter.

### Requirements

- Allowed editors: Visual Studio Code
- Compilation environment: Ubuntu 14.04 LTS using dotnet
- Mandatory README.md file at the root of the project folder
- Each C# task requires its own folder and .csproj file
- Public classes and members should have XML documentation tags
- Private classes and members should be documented without XML documentation tags
