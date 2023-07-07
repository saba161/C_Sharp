public class Factorial
{
    public int FactorialWithRecursion(int n)
    {
        if (n == 1)
            return n;
        else
        {
            var result = FactorialWithRecursion(n - 1) * n;
            return result;
        }
    }

    public int FactorialWithLoop(int n)
    {
        var result = 1;
        for (int i = n; i >= 1; i--)
        {
            result *= i;
        }

        return result;
    }
}