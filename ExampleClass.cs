public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize MyProperty to a default value
        MyProperty = 0; 
    }

    public void MyMethod()
    {
        // Access MyProperty
        int value = MyProperty;

        // Modify MyProperty
        MyProperty = value + 10; 
    }
}