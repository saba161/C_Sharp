namespace Exercise.CSharp.Delegates.Task;

public class Calculator
{
    Func<double, double, double> _mathOperation;

    public Calculator(Func<double, double, double> mathOperation)
    {
        _mathOperation = mathOperation;
    }

    public void Addition()
    {
        
    }
}