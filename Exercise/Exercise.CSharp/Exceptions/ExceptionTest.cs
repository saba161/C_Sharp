using System.Security.Cryptography.X509Certificates;

namespace Exercise.CSharp.Exceptions;

public class ExceptionTest
{
    public void FirstMethod(int a, int b)
    {
        SecondtMethod(a, b);
    }

    public void SecondtMethod(int a, int b)
    {
        ThirdMethod(a, b);
    }

    public void ThirdMethod(int a, int b)
    {
        try
        {
            if (a < 0)
                throw new ArgumentException();
            if (b < 0)
                throw new ArgumentException();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}