public class ExampleClass
{
    public int? MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize MyProperty to a default value
        MyProperty = 0; 
    }

    public void MyMethod()
    {
        // Access MyProperty. Here's a way to safely use it, handling null values.
        int value = MyProperty ?? 0; // Use the null-coalescing operator

        // Modify MyProperty
        MyProperty = value + 10; 
    }
}