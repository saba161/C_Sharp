namespace Exercise.CSharp.Delegates.DelegateWithAnonimous;

public delegate void CountIt(int end);

public class AnonMethDemo2
{
    public void Count()
    {
        CountIt count = delegate(int end)
        {
            for (int i = 0; i <= end; i++)
                Console.WriteLine(i);
        };

        count(2);
        count(10);
    }
}