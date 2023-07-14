namespace Exercise.CSharp.Exceptions;

public class ExecuteException
{
    public void Execute()
    {
        try
        {
            Rethrow.GenException();
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Fatal error - program aborted.");
        }
    }
}