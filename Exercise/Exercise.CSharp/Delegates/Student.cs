namespace Exercise.CSharp.Delegates;

//public delegate void ShowMessage(string message);

public class Student
{
    public void Move(int distance, Action<string> method)
    {
        for (int i = 0; i < distance; i++)
        {
            Thread.Sleep(1000);
            method($"{i}");
        }
    }
}