public class ExecuteThree
{
    public void Execute()
    {
        ThreeD a = new ThreeD(1, 2, 3);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c;

        Console.WriteLine("Coordinats point a: ");
        a.Show();
        Console.WriteLine();

        Console.WriteLine("Coordinats point b: ");
        b.Show();
        Console.WriteLine();

        c = a + b;
        c.Show();
        Console.WriteLine();


        c = a + b + c;
        c.Show();
        Console.WriteLine();
    }
}