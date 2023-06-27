public class ExecuteFailSoftArray
{
    public void Execute()
    {
        FailSoftArray fs = new FailSoftArray(5);
        int x;

        Console.WriteLine("Hidden failure");
        for (int i = 0; i < (fs.Length * 2); i++)
        {
            fs[i] = i * 10;
        }

        for (int i = 0; i < (fs.Length * 2); i++)
        {
            x = fs[i];
            if (x != -1) Console.WriteLine(x + " ");
        }

        Console.WriteLine("Crash with error notification.");
        for (int i = 0; i < (fs.Length * 2); i++)
        {
            fs[i] = i * 10;
            if (fs.ErrFlag)
                Console.WriteLine("fs[" + i + "] out of bounds");
        }
        for (int i = 0; i < (fs.Length * 2); i++)
        {
            x = fs[i];
            if (!fs.ErrFlag) Console.Write(x + " ");
            else
                Console.WriteLine("fs[" + i + "] out of bounds");
        }
    }
}