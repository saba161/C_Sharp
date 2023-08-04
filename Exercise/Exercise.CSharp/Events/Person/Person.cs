namespace Exercise.CSharp.Events;

public class Person
{
    public void Move(int distance)
    {
        for (int i = 0; i < distance; i++)
        {
            Thread.Sleep(1000);
            Moving(this, new MovingArgs($"{i}"));
        }
    }

    public event EventHandler<MovingArgs> Moving;
}