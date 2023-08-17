using Exercise.CSharp.Events;

namespace Exercise.CSharp.Recursion;

public class UseIs
{
    public static void ExecuteIs()
    {
        A a = new A();
        B b = new B();

        if (a is A)
            Console.WriteLine("а is type A");
        if (b is A)
            Console.WriteLine("b compatibility with A, since it is derived from A");
        if (a is B)
            Console.WriteLine("Not output because not derived from B");
        if (b is B)
            Console.WriteLine("В is type В");
        if (a is object)
            Console.WriteLine("а is type object");
    }

    public static void ExecuteAs()
    {
        A a = new A();
        B b = new B();
        b = a as B;
        if (b == null)
            Console.WriteLine("No");
        else
            Console.WriteLine("Yes");
    }
}