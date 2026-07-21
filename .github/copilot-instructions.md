# Copilot Instructions

When performing a code review, apply the following rules to all C# code:

- Flag any C# method that is missing XML documentation comments (`<summary>`, `<param>`, `<returns>`).
- Flag any C# identifier that does not follow Microsoft C# naming conventions (PascalCase for methods/classes, camelCase for locals).
- Flag any method longer than 35 lines as needing refactoring.
- Flag any public API method or class that lacks corresponding unit test coverage.
- Flag any class that has public fields instead of properties.
- Flag any method that has more than 5 parameters as needing refactoring.
