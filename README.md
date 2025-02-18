# Potential NullReferenceException in C# Property Access

This repository demonstrates a common C# coding error where a NullReferenceException can occur if a property is not properly initialized or checked before access. The code in `ExampleClass.cs` shows an example of a class with a property that's initialized in the constructor but doesn't handle the case where the property might be null or has an unexpected default value.  The improved version in `ExampleClassSolution.cs` demonstrates a way to handle it.

## How to Reproduce

1. Clone this repository.
2. Open the project in Visual Studio.
3. Run the application (some testing is required to show the bug). 
4. Observe the potential null reference exception which may not always happen.

## Solution

The improved version handles the potential null reference exception via explicit null checks. However, this scenario is specific and may not cover all cases. Always be mindful of the potential for null values when accessing properties or fields in your C# code, especially if the object is passed into the method from an external source, or if it's possible to construct the class with unexpected values.  Defensive programming techniques are key here.
