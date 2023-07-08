namespace Exercise.CSharp.BoxingAndUnboxing;

public class BoxingDemo
{
    public void Boxing()
    {
        int x;
        x = 10;

        Console.WriteLine("Value x = " + x);

        x = new BoxingDemo().Sqr(x);
    }

    public int Sqr(object o)
    {
        return (int)o * (int)o;
    }
}