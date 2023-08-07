namespace Exercise.CSharp.Events;

public delegate void MyEventHandler();

public class MyEvent
{
    MyEventHandler[] evnt = new MyEventHandler[3];

    public event MyEventHandler SomeEvent
    {
        // Добавить событие в список.
        add
        {
            int i;
            for (i = 0; i < 3; i++)
                if (evnt[i] == null)
                {
                    evnt[i] = value;
                    break;
                }

            if (i == 3) Console.WriteLine("Список событий заполнен.");
        }
// Удалить событие из списка.
        remove
        {
            int i;
            for (i = 0; i < 3; i++)
                if (evnt[i] == value)
                {
                    evnt[i] = null;
                    break;
                }

            if (i == 3) Console.WriteLine("Обработчик событий не найден.");
        }
    }

    // Этот метод вызывается для запуска событий.
    public void OnSomeEvent()
    {
        for (int i = 0; i < 3; i++)
            if (evnt[i] != null)
                evnt[i]();
    }
}

// Создать ряд классов, использующих делегат MyEventHandler.
class W
{
    public void Whandler()
    {
        Console.WriteLine("Событие получено объектом W");
    }
}

class X
{
    public void Xhandler()
    {
        Console.WriteLine("Событие получено объектом X");
    }
}

class Y
{
    public void Yhandler()
    {
        Console.WriteLine("Событие получено объектом Y");
    }
}

class Z
{
    public void Zhandler()
    {
        Console.WriteLine("Событие получено объектом Z");
    }
}