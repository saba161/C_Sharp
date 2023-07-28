namespace Exercise.CSharp.Delegates;

public class ExecuteStudent
{
    public static void Execute()
    {
        Student student = new Student();
        //ShowMessage method = Show;
        student.Move(10, Show);
    }

    public static void Show(string message)
    {
        Console.WriteLine($"{message} + Hello");
    }
}