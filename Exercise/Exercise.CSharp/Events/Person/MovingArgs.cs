namespace Exercise.CSharp.Events;

public class MovingArgs : EventArgs
{
    public MovingArgs(string message)
    {
        Message = message;
    }

    public string Message { get; private set; }
}