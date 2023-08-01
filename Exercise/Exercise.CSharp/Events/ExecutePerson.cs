namespace Exercise.CSharp.Events;

public class ExecutePerson
{
    public static void Execute()
    {
        Person person = new Person();
        person.Moving += student_Moving;

        person.Move(7);
    }

    private static void student_Moving(object sender, MovingArgs e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine(sender);
    }
}