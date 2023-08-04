namespace Exercise.CSharp.Events;

public class Execute
{
    public static void ExecutePerson()
    {
        Person person = new Person();
        person.Moving += student_Moving;

        person.Move(7);
    }

    public static void ExecutePublisher()
    {
        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber(publisher);

        publisher.DoSomething();
    }

    private static void student_Moving(object sender, MovingArgs e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine(sender);
    }
}