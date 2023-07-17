namespace Exercise.CSharp.FileStream;

public static class ShowFile
{
    public static void Show(string[] args)
    {
        int i;
        System.IO.FileStream fin;

        if (args.Length != 1)
        {
            Console.WriteLine("Use file");
            return;
        }

        try
        {
            fin = new System.IO.FileStream(args[0], FileMode.Open);
        }
        catch (IOException e)
        {
            Console.WriteLine("can't open file");
            Console.WriteLine(e.Message);
            return;
        }

        try
        {
            do
            {
                i = fin.ReadByte();
                if (i != -1) Console.Write((char)i);
            } while (i != -1);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Ошибка чтения файла");
            Console.WriteLine(exc.Message);
        }
        finally
        {
            fin.Close();
        }
    }
}