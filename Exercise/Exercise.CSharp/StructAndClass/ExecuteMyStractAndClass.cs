namespace Exercise.CSharp.StructAndClass;

public class ExecuteMyStractAndClass
{
    public void ExecuteStruct()
    {
        MyStract a;
        MyStract b;

        a.x = 10;
        b.x = 20;

        Console.WriteLine($"a: {a.x}, b: {b.x}");

        a = b;
        b.x = 30;

        Console.WriteLine($"a: {a.x}, b: {b.x}");
    }

    public void ExecuteClass()
    {
        MyClass a = new MyClass();
        MyClass b = new MyClass();

        a.x = 10;
        b.x = 20;

        Console.WriteLine($"a: {a.x}, b: {b.x}");

        a = b;
        b.x = 30;

        Console.WriteLine($"a: {a.x}, b: {b.x}");
    }
}