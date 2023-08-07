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

    public static void ExecuteMyEvent()
    {
        MyEvent evt = new MyEvent();
        W wOb = new W();
        X xOb = new X();
        Y yOb = new Y();
        Z zOb = new Z();
        
        // Добавить обработчики в цепочку событий.
        Console.WriteLine("Добавление событий. ");
        evt.SomeEvent += wOb.Whandler;
        evt.SomeEvent += xOb.Xhandler;
        evt.SomeEvent += yOb.Yhandler;
        // Сохранить нельзя - список заполнен.
        evt.SomeEvent += zOb.Zhandler;
        Console.WriteLine();
        // Запустить события.
        evt.OnSomeEvent();
        Console.WriteLine();
        // Удалить обработчик.
        Console.WriteLine("Удаление обработчика xOb.Xhandler.");
        evt.SomeEvent -= xOb.Xhandler;
        evt.OnSomeEvent();
        Console.WriteLine();
// Попробовать удалить обработчик еще раз.
        Console.WriteLine("Попытка удалить обработчик " +
                          "xOb.Xhandler еще раз.");
        evt.SomeEvent -= xOb.Xhandler;
        evt.OnSomeEvent();
        Console.WriteLine();
// А теперь добавить обработчик Zhandler.
        Console.WriteLine("Добавление обработчика zOb.Zhandler.");
        evt.SomeEvent += zOb.Zhandler;
        evt.OnSomeEvent();
    }

    private static void student_Moving(object sender, MovingArgs e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine(sender);
    }
}