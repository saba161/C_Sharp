namespace Exercise.CSharp.Exceptions;

public class Rethrow
{
    public static void GenException()
    {
        int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
        int[] denom = { 2, 0, 4, 4, 0, 8 };

        for (int i = 0; i < numer.Length; i++)
        {
            try
            {
                Console.WriteLine(numer[i] + " / " +
                                  denom[i] + " Equal " +
                                  numer[i] / denom[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Matching item not found.");
                throw;
            }
        }
    }
}